using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace qxDotNet.Common
{
    public class ApplicationState
    {

        private Application.AbstractGui _app;
        private string _name;
        private long _requestId = 1;
        private long _controlCounter = 0;
        private bool _isRefreshRequest;
        private List<Core.Object> _createdControls;
        private List<Core.Object> _renderedControls;
        private Dictionary<long, WeakReference> _registeredControls;

        public ApplicationState(string name, Application.AbstractGui app)
        {
            _registeredControls = new Dictionary<long, WeakReference>();
            _name = name;
            _app = app;
        }

        public static ApplicationState Instance
        {
            get
            {
                return (System.Web.HttpContext.Current.Session["__qxAppState"] as ApplicationState);
            }
        }

        public qxDotNet.Application.AbstractGui GUI
        {
            get
            {
                return _app;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        internal void ProcessRequest(HttpContext context)
        {
            _isRefreshRequest = false;
            var response = context.Response;

            if (context.Request.HttpMethod.ToLower() == "post")
            {
                var request = context.Request;
                var clientId = request.Form["req"];
                if (clientId == "0")
                {
                    _isRefreshRequest = true;
                }
                if (clientId != "0" && _requestId.ToString() != clientId)
                {
                    response.Write("window.location.reload();\n");
                    return;
                }

                foreach (var k in request.Form.AllKeys)
                {
                    switch (k)
                    {
                        case "req":
                            continue;
                        case "ev":
                            var evData = request.Form[k];
                            var evXML = new System.Xml.XmlDocument();
                            try
                            {
                                evXML.LoadXml(evData);
                            }
                            catch
                            {
                                // invalid input data? Get out!
                                break;
                            }
                            if (evXML.ChildNodes.Count > 0)
                            {
                                var eventsToInvoke = new List<Pair<Core.Object, string>>();
                                foreach (XmlElement node in evXML.ChildNodes[0].ChildNodes)
                                {
                                    var sid = node.GetAttribute("_id");
                                    var sev = node.GetAttribute("_n");
                                    if (sid != null && sev != null)
                                    {
                                        long id;
                                        if (long.TryParse(sid, out id))
                                        {
                                            if (_registeredControls.ContainsKey(id))
                                            {
                                                var control = (_registeredControls[id].Target as Core.Object);
                                                if (control != null)
                                                {
                                                    eventsToInvoke.Add(new Pair<Core.Object, string>(control, sev));
                                                    foreach (XmlAttribute item in node.Attributes)
                                                    {
                                                        if (item.LocalName != "_id" && item.LocalName != "_n")
                                                        {
                                                            control.SetPropertyValue(item.LocalName, decodeXMLAttribute(item.Value));
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                foreach (var item in eventsToInvoke)
                                {
                                    item.LeftPair.InvokeEvent(item.RightPair);
                                }
                            }
                            break;
                    }
                }

            }
            else
            {
                _isRefreshRequest = true;
            }

            _app.ProcessRequest();

            response.Write("var App = qx.core.Init.getApplication();\n");
            response.Write("var ctr = App.getControls();\n");
            response.Write("var root = App.getRoot();\n");

            _createdControls = new List<qxDotNet.Core.Object>();
            CreateRecursive(_app, context.Response);
            _createdControls = null;

            _renderedControls = new List<qxDotNet.Core.Object>();
            RenderRecursive(_app, context.Response);
            _renderedControls = null;

            if (!_isRefreshRequest)
            {
                _requestId++;
            }
            response.Write("App.requestCounter = \"" + _requestId.ToString() + "\";\n");
        }

        private string decodeXMLAttribute(string attr)
        {
            return attr
                .Replace("&amp;#10;", "\n")
                .Replace("&quot;", "\"")
                .Replace("&lt;", "<")
                .Replace("&gt;", ">")
                .Replace("&amp;", "&");
        }

        internal long RequestControlId()
        {
            _controlCounter++;
            return _controlCounter;
        }

        public Core.Object GetControlByID(long id)
        {
            if (_registeredControls.ContainsKey(id))
            {
                return _registeredControls[id].Target as Core.Object;
            }
            return null;
        }

        private void CreateRecursive(Core.Object obj, HttpResponse response)
        {
            if (_createdControls.Contains(obj))
            {
                return;
            }
            _createdControls.Add(obj);
            var st = obj.GetState();
            obj.Render(st);
            if (!obj.DisallowCreation && (_isRefreshRequest || !obj.IsCreated))
            {
                if (!_registeredControls.ContainsKey(obj.clientId))
                {
                    _registeredControls.Add(obj.clientId, new WeakReference(obj));
                }
                response.Write(string.Format("{0} = new {1}({2});\n", obj.GetReference(), obj.GetTypeName(), obj.GetCustomConstructor()));
            }

            var props = st.GetAllProperies();

            foreach (var p in props)
            {
                if (p.Value is qxDotNet.Core.Object)
                {
                    CreateRecursive(p.Value as qxDotNet.Core.Object, response);
                }
            }

            var children = obj.GetChildren(false);

            if (children != null)
            {
                foreach (var item in children)
                {
                    if (item != null)
                    {
                        CreateRecursive((item as Core.Object), response);
                    }
                }
            }
        }

        private void RenderRecursive(Core.Object obj, HttpResponse response)
        {
            var stateBag = obj.GetState();
            Dictionary<string, object> properties;
            List<Core.Object.EventInfo> events;
            var st = obj.GetState();
            if (_isRefreshRequest || !obj.IsCreated)
            {
                properties = st.GetAllProperies();
                events = st.GetAllEvents();
            }
            else
            {
                properties = st.GetNewProperties();
                events = st.GetNewEvents();
            }

            if (!_isRefreshRequest)
            {
                var removed = obj.GetRemovedChildren();
                if (removed != null)
                {
                    foreach (Core.Object item in removed)
                    {
                        response.Write(obj.GetRemoveObjectReference(item));
                    }
                }
            }

            var children = obj.GetChildren(!_isRefreshRequest);

            // font hack
            var fontList = new List<qxDotNet.Font>();
            foreach (var p in st.GetAllProperies())
            {
                if (p.Value is qxDotNet.Font)
                {
                    (p.Value as qxDotNet.Font).fontRenderPhase = false;
                    RenderRecursive(p.Value as qxDotNet.Core.Object, response);
                    (p.Value as qxDotNet.Font).fontRenderPhase = true;
                    fontList.Add(p.Value as qxDotNet.Font);
                }
            }

            if (children != null)
            {
                foreach (Core.Object item in children)
                {
                    if (item != null)
                    {
                        if (!item.DisallowCreation)
                        {
                            response.Write(obj.GetAddObjectReference(item));
                        }
                    }
                }
            }

            children = obj.GetChildren(false);

            obj.CustomPreRender(response, _isRefreshRequest);

            foreach (var p in st.GetAllProperies())
            {
                if (p.Value is qxDotNet.Core.Object)
                {
                    RenderRecursive(p.Value as qxDotNet.Core.Object, response);
                    _renderedControls.Add(p.Value as qxDotNet.Core.Object);
                }
            }

            if (children != null)
            {
                foreach (var item in children)
                {
                    if (item != null)
                    {
                        if (!_renderedControls.Contains(item as Core.Object))
                        {
                            RenderRecursive((item as Core.Object), response);
                        }
                    }
                }
            }

            if (obj is qxDotNet.Font)
            {
                //font hack
                foreach (var prop in properties)
                {
                    var fontObj = obj as qxDotNet.Font;
                    if (prop.Key == "size")
                    {
                        if (!fontObj.fontRenderPhase)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (fontObj.fontRenderPhase)
                        {
                            continue;
                        }
                    }
                    response.Write(obj.GetSetPropertyValueExpression(prop.Key, prop.Value));
                }
            }
            else
            {
                foreach (var prop in properties)
                {
                    response.Write(obj.GetSetPropertyValueExpression(prop.Key, prop.Value));
                }
            }

            // font hack
            foreach (var item in fontList)
            {
                RenderRecursive(item as qxDotNet.Core.Object, response);
            }

            foreach (var ev in events)
            {
                response.Write(obj.GetReference() + ".addListener(\"" + ev.name + "\", function(e) {");
                if (ev.modifiedProperies.Count == 0)
                {
                    response.Write("App.ev(" + obj.clientId + ", \"" + ev.name + "\", null);\n");
                }
                else
                {
                    var props = "";
                    foreach (var item in ev.modifiedProperies)
                    {
                        if (ev.referencedProperies.Contains(item))
                        {
                            props += ".pr(\"" + item + "\",";
                            props += "\"" + obj.GetGetPropertyAccessor(item, true) + "\"";
                            props += ")";
                        }
                        else
                        {
                            props += ".pr(\"" + item + "\",";
                            props += "\"" + obj.GetGetPropertyAccessor(item, false) + "\"";
                            props += ")";
                        }
                    }
                    response.Write("App.ev(" + obj.clientId + ", \"" + ev.name + "\")" + props + ";\n");
                }
                if (ev.callServer)
                {
                    response.Write("App.send();");
                }
                response.Write("});");
            }

            obj.CustomPostRender(response, _isRefreshRequest);

            if (!(obj is qxDotNet.Font) || (obj as qxDotNet.Font).fontRenderPhase)
            {
                obj.Commit();
            }
        }

        public static void RestartApplication()
        {
            System.Web.HttpContext.Current.Session["__qxAppState"] = null;
            System.Web.HttpContext.Current.Response.Write("window.location.reload();\n");
        }

    }
}
