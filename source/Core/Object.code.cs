using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace qxDotNet.Core
{

    /// <summary>
    /// The qooxdoo root class. All other classes are direct or indirect subclasses of this one.  
    /// This class contains methods for:   object management (creation and destruction) interfaces for event system generic setter/getter support interfaces for logging console user friendly OO interfaces like {@link #self} or {@link #base} 
    /// </summary>
    public abstract class Object : INotifyPropertyChanged
    {
        private long _clientId = 0;
        private bool _created = false;
        private PropertyBag _state;
        private ClientMethodCallBag _newMethods;
        private ClientMethodCallBag _appliedMethods;
        private Dictionary<string, BindingInfo> _bindings;

        public Object()
        {
            _state = new PropertyBag(this);
            _newMethods = new ClientMethodCallBag();
            _appliedMethods = new ClientMethodCallBag();
            _bindings = new Dictionary<string, BindingInfo>();
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
                OnPropertyChanged(p.Name);
            }
        }

        /// <summary>
        /// Returns client side identifier for this object
        /// </summary>
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
        /// Returns client class name
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
            if (isRefreshRequest)
            {
                foreach (var item in _appliedMethods.Get())
                {
                    response.Write(item.GetExpression(this));
                }
            }
            foreach (var item in _newMethods.Get())
            {
                response.Write(item.GetExpression(this));
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
            return GetReference() + ".add(" + obj.GetReference() + ");\n";
        }

        protected internal virtual string GetRemoveObjectReference(Object obj)
        {
            return GetReference() + ".remove(" + obj.GetReference() + ");\n";
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
            foreach (var item in _newMethods.Get())
            {
                _appliedMethods.Add(item);
            }
            _newMethods.Clear();
        }

        protected internal virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The function is responsible for binding a source objects property to a target objects property. Both properties have to have the usual qooxdoo getter and setter. The source property also needs to fire change-events on every change of its value. Please keep in mind, that this binding is unidirectional. If you need a binding in both directions, you have to use two of this bindings.
        /// It’s also possible to bind some kind of a hierarchy as a source. This means that you can separate the source properties with a dot and bind by that the object referenced to this property chain. Example with an object ‘a’ which has object ‘b’ stored in its ‘child’ property. Object b has a string property named abc:
        /// 
        /// qx.data.SingleValueBinding.bind(a, "child.abc", textfield, "value");
        /// 
        /// In that case, if the property abc of b changes, the textfield will automatically contain the new value. Also if the child of a changes, the new value (abc of the new child) will be in the textfield.
        /// There is also a possibility of binding an array. Therefore the array  qx.data.IListData is needed because this array has change events which the native does not. Imagine a qooxdoo object a which has a children property containing an array holding more of its own kind. Every object has a name property as a string.
        /// 
        /// var svb = qx.data.SingleValueBinding;
        /// // bind the first child's name of 'a' to a textfield
        /// svb.bind(a, "children[0].name", textfield, "value");
        /// // bind the last child's name of 'a' to a textfield
        /// svb.bind(a, "children[last].name", textfield2, "value");
        /// // also deeper bindings are possible
        /// svb.bind(a, "children[0].children[0].name", textfield3, "value");
        /// 
        /// As you can see in this example, the abc property of a’s b will be bound to the textfield. If now the value of b changed or even the a will get a new b, the binding still shows the right value.
        /// </summary>
        /// <param name="sourcePropertyChain">The property chain which represents the source property.</param>
        /// <param name="targetObject">The object which the source should be bind to.</param>
        /// <param name="targetProperty">The property chain to the target object.</param>
        /// <param name="options">A map containing the options.
        /// •  converter: A converter function which takes four parameters and should return the converted value. 
        /// 1.	The data to convert
        /// 2.	The corresponding model object, which is only set in case of the use of an controller.
        /// 3.	The source object for the binding
        /// 4.	The target object.
        /// If no conversion has been done, the given value should be returned. e.g. a number to boolean converter function(data, model, source, target) {return data > 100;} 
        /// •  onUpdate: A callback function can be given here. This method will be called if the binding was updated successful. There will be three parameter you do get in that method call. 
        /// 1.	The source object
        /// 2.	The target object
        /// 3.	The data
        /// Here is a sample: onUpdate : function(source, target, data) {...} 
        /// •  onSetFail: A callback function can be given here. This method will be called if the set of the value fails. 
        /// •  ignoreConverter: A string which will be matched using the current property chain. If it matches, the converter will not be called. 
        /// </param>
        /// <returns></returns>
        public object Bind(string sourcePropertyChain, qxDotNet.Core.Object targetObject, string targetProperty, Map options = null)
        {
            var b = new BindingInfo();
            b.sourceProperty = sourcePropertyChain;
            b.target = targetObject;
            b.targetProperty = targetProperty;
            b.options = options;
            var key = b.getKey();
            _bindings[key] = b;
            var c = new ClientMethodCall("bind")
                .SetKeyParameter(b.sourceProperty)
                .SetKeyParameter(b.target)
                .SetKeyParameter(b.targetProperty);
            if (b.options != null)
            {
                c.SetParameter(b.options);
            }
            CallClientMethod(c);
            return b;
        }

        /// <summary>
        /// Removes all bindings from the object.
        /// </summary>
        public void RemoveAllBindings()
        {
            _bindings.Clear();
            CallClientMethod(new ClientMethodCall("removeAllBindings"));
        }

        /// <summary>
        /// Returns client side reference for this object
        /// </summary>
        /// <returns></returns>
        internal protected virtual string GetReference()
        {
            return "ctr[" + clientId + "]";
        }

        internal void CallClientMethod(ClientMethodCall method)
        {
            _newMethods.Add(method);
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

        /// <summary>
        /// Converts value to client side javascript value
        /// </summary>
        /// <param name="value">Value to convert</param>
        /// <returns>Valid javascript value</returns>
        public static string GetClientValue(object value)
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
            else if (value is qxDotNet.Map)
            {
                return value.ToString();
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
