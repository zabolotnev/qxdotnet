using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// A Input wrap any valid HTML input element and make it accessible through the normalized qooxdoo element interface.
    /// </summary>
    public partial class Input : qxDotNet.Html.Element
    {

        private string _value = "";
        private bool? _wrap = false;


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

        /// <summary>
        /// 
        /// </summary>
        public bool? Wrap
        {
            get
            {
                return _wrap;
            }
            set
            {
               _wrap = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.html.Input";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("value", _value, "");
            state.SetPropertyValue("wrap", _wrap, false);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
