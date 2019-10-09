using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Configuration;

namespace qxDotNet.Common
{
    public partial class ClientHandler : IHttpHandler, IRequiresSessionState
    {

        public bool IsReusable
        {
            get 
            {
                return true;
            }
        }

        public void ProcessRequest(System.Web.HttpContext context)
        {
            var appState = (context.Session["__qxAppState"] as ApplicationState);
            if (appState == null)
            {
                var p = context.Request.AppRelativeCurrentExecutionFilePath;
                if (p[0] == '~')
                {
                    p = p.Remove(0, 1);
                }
                if (p[0] == '/')
                {
                    p = p.Remove(0, 1);
                }
                var app = createApp(p.ToLower());
                if (app == null)
                {
                    throw new InvalidOperationException("Invalid configuration");
                }

                appState = new ApplicationState(p, app);
                context.Session["__qxAppState"] = appState;
                appState.GUI.Main();
                appState.GUI.Commit();
            }

            if (context.Request.Params["r"] == "grid")
            {
                TableState.Instance.ProcessRequest(context);
            }
            else
            {
                if (context.Request.HttpMethod.ToLower() == "post")
                {
                    appState.ProcessRequest(context);
                    context.Response.ContentType = "application/javascript";
                }
                else
                {
                    context.Response.ContentType = "text/html";
                    context.Response.Write(Properties.Resources.StandaloneBootstrap.Replace("%APPNAME%", "/" + appState.Name));
                }
            }
        }

        private static Application.AbstractGui createAppFromConfig(string path)
        {
            var section = (ConfigHandler)ConfigurationManager.GetSection("qxSettings");
            if (section != null)
            {
                foreach (ConfigApplicationHandler item in section.Applications)
                {
                    if (path == item.Path.ToLower())
                    {
                        var t = Type.GetType(item.Type);
                        var ctcr = t.GetConstructor(System.Type.EmptyTypes);
                        if (ctcr != null)
                        {
                            return (Application.AbstractGui)ctcr.Invoke(null);
                        }
                    }
                }
            }
            return null;
        }

        private static Application.AbstractGui createApp(string path)
        {
            var r = createAppFromConfig(path);
            if (r != null)
            {
                return r;
            }
            var assms = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var asm in assms)
            {
                foreach (var t in asm.GetTypes())
                {
                    var attrs = t.GetCustomAttributes(typeof(AppPathAttribute), false);
                    if (attrs.Length > 0)
                    {
                        var attr = attrs[0] as AppPathAttribute;
                        if (attr.Path != null && attr.Path.ToLower() == path)
                        {
                            var ctcr = t.GetConstructor(System.Type.EmptyTypes);
                            if (ctcr != null)
                            {
                                return (Application.AbstractGui)ctcr.Invoke(null);
                            }
                        }
                    }
                }
            }
            return null;
        }

    }
}
