using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// A Button widget.  Example  Here is a little example of how to use the widget.    var button = new qx.ui.mobile.form.Button(\HelloWorld\);   button.addListener(\tap\, function(e) {  alert(\Buttonwasclicked\);  }, this);   this.getRoot.add(button);   This example creates a button with the label "Hello World" and attaches an event listener to the {@link qx.ui.mobile.core.Widget#tap} event.
    /// </summary>
    public partial class Button : qxDotNet.UI.Mobile.Basic.Atom
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
            return "qx.ui.mobile.form.Button";
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
