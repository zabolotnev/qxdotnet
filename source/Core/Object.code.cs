using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.Core
{
    public abstract class Object
    {
        private long _clientId = 0;
        private bool _created = false;
        private PropertyBag _state;
        private Dictionary<string, BindingInfo> _newBindings;
        private Dictionary<string, BindingInfo> _appliedBindings;
        private bool _needToRemoveBindings = false;

        public Object()
        {
            _state = new PropertyBag(this);
            _newBindings = new Dictionary<string, BindingInfo>();
            _appliedBindings = new Dictionary<string, BindingInfo>();
        }

        private static Dictionary<string, Dictionary<string, System.Reflection.PropertyInfo>> _propertyCache 
            = new Dictionary<string, Dictionary<string, System.Reflection.PropertyInfo>>();

        private static void checkPropertyCache(Type type)
        {
            var name = type.FullName;
            lock (_propertyCache)
            {
                if (!_propertyCache.ContainsKey(name))
                {
                    var rec = new Dictionary<string, System.Reflection.PropertyInfo>();
                    foreach (var p in type.GetProperties())
                    {
                        if (p.GetIndexParameters().Length == 0)
                        {
                            var propName = p.Name.ToLower();
                            var attr = p.GetCustomAttributes(typeof (Common.PropertyNameAttribute), false);
                            if (attr != null)
                            {
                                if (attr.Length > 0)
                                {
                                    var ca = (attr[0] as Common.PropertyNameAttribute);
                                    if (ca.Name != null && ca.Name != "")
                                    {
                                        propName = ca.Name.ToLower();
                                    }
                                }
                            }
                            rec.Add(propName, p);
                        }
                    }
                    _propertyCache.Add(name, rec);
                }
            }
        }

        protected internal virtual void SetPropertyValue(string name, string value)
        {
            name = name.ToLower();
            var t = this.GetType();
            checkPropertyCache(t);
            System.Reflection.PropertyInfo p = null;
            lock (_propertyCache)
            {
                if (_propertyCache.ContainsKey(t.FullName))
                {
                    var rec = _propertyCache[t.FullName];
                    if (rec.ContainsKey(name))
                    {
                        p = rec[name];
                    }
                }
            }
            if (p != null)
            {
                p.SetValue(this, ConvertToType(p.PropertyType, value), null);
            }
        }

        public long clientId
        {
            get
            {
                if (_clientId == 0)
                {
                    _clientId = Common.ApplicationState.Instance.RequestControlId();
                }
                return _clientId;
            }
        }

        /// <summary>
        /// Returns native class name
        /// </summary>
        /// <returns>Native class name</returns>
        protected internal abstract string GetTypeName();

        internal virtual void Render(PropertyBag state)
        {
            
        }

        protected internal virtual void CustomPreRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {

        }

        protected internal virtual void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            foreach (var item in _newBindings)
            {
                if (item.Value.options == null)
                {
                    response.Write(
                        GetReference() +
                        ".bind(" +
                        GetClientValue(item.Value.sourceProperty) +
                        "," +
                        item.Value.target.GetReference() +
                        "," +
                        GetClientValue(item.Value.targetProperty) + ");\n");
                }
                else
                {
                    response.Write(
                        GetReference() +
                        ".bind(" +
                        GetClientValue(item.Value.sourceProperty) +
                        "," +
                        item.Value.target.GetReference() +
                        "," +
                        GetClientValue(item.Value.targetProperty) + 
                        "," +
                        item.Value.options.ToString() + ");\n");
                }
            }
            if (isRefreshRequest)
            {
                foreach (var item in _appliedBindings)
                {
                    if (item.Value.options == null)
                    {
                        response.Write(
                            GetReference() +
                            ".bind(" +
                            GetClientValue(item.Value.sourceProperty) +
                            "," +
                            item.Value.target.GetReference() +
                            "," +
                            GetClientValue(item.Value.targetProperty) + ");\n");
                    }
                    else
                    {
                        response.Write(
                            GetReference() +
                            ".bind(" +
                            GetClientValue(item.Value.sourceProperty) +
                            "," +
                            item.Value.target.GetReference() +
                            "," +
                            GetClientValue(item.Value.targetProperty) +
                            "," +
                            item.Value.options.ToString() + ");\n");
                    }
                }
            }
            if (_needToRemoveBindings)
            {
                response.Write(GetReference() + ".removeAllBindings();\n");
            }
        }

        protected internal virtual string GetCustomConstructor()
        {
            return string.Empty;
        }

        internal virtual void InvokeEvent(string eventName)
        {

        }

        protected internal virtual System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            return null;
        }

        protected internal virtual bool RenderChildrenBeforeAdd
        {
            get
            {
                return false;
            }
        }

        protected internal virtual System.Collections.IEnumerable GetRemovedChildren()
        {
            return null;
        }

        protected internal virtual string GetAddObjectReference(Object obj)
        {
            return null;
        }

        protected internal virtual string GetRemoveObjectReference(Object obj)
        {
            return null;
        }

        internal PropertyBag GetState()
        {
            return _state;
        }
        
        internal bool IsCreated
        {
            get
            {
                return _created;
            }
        }

        internal virtual bool DisallowCreation
        {
            get
            {
                return false;
            }
        }

        internal virtual void Commit()
        {
            _created = true;
            _state.Commit();
            foreach (var item in _newBindings)
            {
                _appliedBindings.Add(item.Key, item.Value);
            }
            _newBindings.Clear();
            _needToRemoveBindings = false;
        }

        public void Bind(string sourcePropertyChain, qxDotNet.Core.Object targetObject, string targetProperty)
        {
            this.Bind(sourcePropertyChain, targetObject, targetProperty, null);
        }

        public void Bind(string sourcePropertyChain, qxDotNet.Core.Object targetObject, string targetProperty, Map options)
        {
            var b = new BindingInfo();
            b.sourceProperty = sourcePropertyChain;
            b.target = targetObject;
            b.targetProperty = targetProperty;
            b.options = options;
            var key = b.getKey();
            if (!_appliedBindings.ContainsKey(key) && !_newBindings.ContainsKey(key))
            {
                _newBindings.Add(key, b);
            }
        }

        public void RemoveAllBindings()
        {
            _needToRemoveBindings = true;
            _newBindings.Clear();
            _appliedBindings.Clear();
        }

        protected internal virtual string GetReference()
        {
            return "ctr[" + clientId + "]";
        }

        protected internal virtual string GetGetPropertyAccessor(string name, bool isRef)
        {
            if (char.IsLetter(name[0]))
            {
                var fl = char.ToUpper(name[0]);
                name = GetReference() + ".get" + fl + name.Substring(1) + "()";
            }
            else
            {
                name = GetReference() + ".get" + name + "()";
            }
            if (isRef)
            {
                name += "._id_";
            }
            return name;
        }

        protected internal virtual string GetSetPropertyValueExpression(string name, object value)
        {
            return GetReference() + "." + GetSetPropertyAccessor(name) + "(" + GetClientValue(value) + ");\n";
        }

        protected internal virtual string GetSetPropertyAccessor(string name)
        {
            if (char.IsLetter(name[0]))
            {
                var fl = char.ToUpper(name[0]);
                name = "set" + fl + name.Substring(1);
            }
            else
            {
                name = "set" + name;
            }
            return name;
        }

        protected internal virtual string GetClientValue(object value)
        {
            if (value == null)
            {
                return "null";
            }
            else if (value is bool)
            {
                var v = (bool)value;
                return v ? "true" : "false";
            }
            else if (value is bool?)
            {
                var v = (bool?)value;
                if (v.HasValue)
                {
                    return v.Value ? "true" : "false";
                }
                else
                {
                    return "null";
                }
            }
            else if (value is DateTime)
            {
                return "new Date(Date.parse(\"" + ((DateTime)value).ToString("dd MMM yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture) + "\"))";
            }
            else if (value is DateTime?)
            {
                if (!((DateTime?)value).HasValue)
                {
                    return "null";
                }
                else
                {
                    return "new Date(Date.parse(\"" + ((DateTime?)value).Value.ToString("dd MMM yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture) + "\"))";
                }
            }
            else if (value is string)
            {
                return "\"" + (value as string).EscapeToJS() + "\"";
            }
            else if (value is Core.Object)
            {
                return (value as Core.Object).GetReference();
            }
            else if (value is Enum)
            {
                return "\"" + Enum.GetName(value.GetType(), value) + "\"";
            }
            else
            {
                return value.ToString().EscapeToJS();
            }
        }

        protected internal virtual object ConvertToType(Type type, string value)
        {
            if (type.IsSubclassOf(typeof(Core.Object)))
            {
                long id = 0;
                if (long.TryParse(value, out id))
                {
                    return Common.ApplicationState.Instance.GetControlByID(id);
                }
                else
                {
                    return null;
                }
            }
            else if (type.IsSubclassOf(typeof(Enum)))
            {
                return Enum.Parse(type, value, false);
            }
            else if (type == typeof(bool))
            {
                return bool.Parse(value);
            }
            else if (type == typeof(bool?))
            {
                bool b;
                if (bool.TryParse(value, out b))
                {
                    return b;
                }
                else
                {
                    return null;
                }
            }
            else if (type == typeof(DateTime))
            {
                var v = value.Substring(0, value.IndexOf(" GMT"));
                return DateTime.ParseExact(v, "ddd MMM d yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }
            else if (type == typeof(DateTime?))
            {
                if (string.IsNullOrEmpty(value))
                {
                    return null;
                }
                DateTime r;
                var v = value.Substring(0, value.IndexOf(" GMT"));
                if (DateTime.TryParseExact(v, "ddd MMM d yyyy HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out r))
                {
                    return r;
                }
                else
                {
                    return null;
                }
            }
            else if (type == typeof(int))
            {
                return int.Parse(value);
            }
            else if (type == typeof(long))
            {
                return long.Parse(value);
            }
            else if (type == typeof(decimal))
            {
                return decimal.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
            }
            else return Convert.ChangeType(value, type, System.Globalization.CultureInfo.InvariantCulture);
        }

        internal class PropertyBag
        {

            private Dictionary<string, object> _newPropertyValues;
            private Dictionary<string, object> _committedPropertyValues;
            private Dictionary<string, EventInfo> _newEvents;
            private Dictionary<string, EventInfo> _committedEvents;
            private Object _owner;

            public PropertyBag(Object AOwner)
            {
                _owner = AOwner;
                _newPropertyValues = new Dictionary<string, object>();
                _committedPropertyValues = new Dictionary<string, object>();
                _newEvents = new Dictionary<string, EventInfo>();
                _committedEvents = new Dictionary<string, EventInfo>();
            }

            public void Commit()
            {
                foreach (var item in _newEvents)
                {
                    _committedEvents[item.Key] = item.Value;
                }
                foreach (var item in _newPropertyValues)
                {
                    _committedPropertyValues[item.Key] = item.Value;
                }
                _newPropertyValues.Clear();
                _newEvents.Clear();
            }

            public Dictionary<string, object> GetAllProperies()
            {
                var result = new Dictionary<string, object>();
                foreach (var item in _committedPropertyValues)
                {
                    result[item.Key] = item.Value;
                }
                foreach (var item in _newPropertyValues)
                {
                    result[item.Key] = item.Value;
                }
                return result;
            }

            public Dictionary<string, object> GetNewProperties()
            {
                return _newPropertyValues;
            }

            public List<EventInfo> GetAllEvents()
            {
                var result = new Dictionary<string, EventInfo>();
                foreach (var item in _committedEvents)
                {
                    result[item.Key] = item.Value;
                }
                foreach (var item in _newEvents)
                {
                    result[item.Key] = item.Value;
                }
                return result.Values.OrderBy(f => f.callServer).ToList();
            }

            public List<EventInfo> GetNewEvents()
            {
                return _newEvents.Values.OrderBy(f => f.callServer).ToList();
            }

            public void SetPropertyValue(string propertyName, object value, object defaultValue)
            {
                if (_committedPropertyValues.ContainsKey(propertyName))
                {
                    if (object.Equals(_committedPropertyValues[propertyName], value))
                    {
                        return;
                    }
                    if (_owner.IsCreated || !object.Equals(value, defaultValue))
                    {
                        _newPropertyValues[propertyName] = value;
                    }
                }
                else
                {
                    var isEquals = false;
                    if (value == null && defaultValue == null)
                        isEquals = true;
                    else
                        if (value == defaultValue)
                            isEquals = true;
                        else
                            if (defaultValue != null)
                                if (defaultValue.Equals(value))
                                    isEquals = true;
                    if (!isEquals)
                    {
                        _newPropertyValues[propertyName] = value;
                    }
                }
            }

            public EventInfo SetEvent(string eventName, bool callServer, params string[] modifiedProperty)
            {
                return SetEvent(eventName, callServer, modifiedProperty.ToList());
            }

            public EventInfo SetEvent(string eventName, bool callServer, List<string> modifiedProperties)
            {
                var ev = new EventInfo() { name = eventName, modifiedProperies = modifiedProperties, callServer = callServer };
                if (modifiedProperties != null)
                {
                    var t = _owner.GetType();
                    checkPropertyCache(t);
                    lock (_propertyCache)
                    {
                        if (_propertyCache.ContainsKey(t.FullName))
                        {
                            var rec = _propertyCache[t.FullName];
                            foreach (var item in modifiedProperties)
                            {
                                if (rec.ContainsKey(item))
                                {
                                    var p = rec[item];
                                    if (p.PropertyType.IsSubclassOf(typeof(qxDotNet.Core.Object)))
                                    {
                                        ev.referencedProperies.Add(item);
                                    }
                                }
                            }
                        }
                    }
                }
                SetEvent(ev);
                return ev;
            }

            public EventInfo SetEvent(string eventName, bool callServer)
            {
                var ev = new EventInfo() { name = eventName, callServer = callServer };
                SetEvent(ev);
                return ev;
            }

            public void SetEvent(EventInfo ev)
            {
                if (_newEvents.ContainsKey(ev.name) || !_committedEvents.ContainsKey(ev.name))
                {
                    _newEvents[ev.name] = ev;
                }
            }

        }

        public class EventInfo
        {

            public EventInfo()
            {
                modifiedProperies = new List<string>();
                referencedProperies = new List<string>();
                CustomCallServerExpression = "App.send();";
            }

            public string name { get; set; }
            public List<string> modifiedProperies { get; set; }
            public bool callServer { get; set; }
            public string CustomCallServerExpression { get; set; }
			public string CustomEventCondition { get; set; }
            public List<string> referencedProperies { get; set; }
            public bool IsEventSent { get; set; }
        }

        private class BindingInfo
        {
            public string getKey()
            {
                return sourceProperty + "_" + target.clientId.ToString() + "_" + targetProperty;
            }

            public string sourceProperty;
            public qxDotNet.Core.Object target;
            public string targetProperty;
            public Map options;
        }

    }
}
