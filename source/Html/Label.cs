using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// A cross browser label instance with support for rich HTML and text labels.  Text labels supports ellipsis to reduce the text width.  The mode can be changed through the method {@link #setRich} which accepts a boolean value. The default mode is "text" which is a good choice because it has a better performance.
    /// </summary>
    public partial class Label : qxDotNet.Html.Element
    {

        private string _value = "";


        /// <summary>
        /// 
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
               _value = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.html.Label";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("value", _value, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
