using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Basic
{
    /// <summary>
    /// The label widget displays a text or HTML content. Example  Here is a little example of how to use the widget.    var label = new qx.ui.mobile.basic.Label(\HelloWorld\);   this.getRoot().add(label);   This example create a widget to display the label.
    /// </summary>
    public partial class Label : qxDotNet.UI.Mobile.Core.Widget
    {

        private string _value = null;
        private bool? _wrap = true;


        /// <summary>
        /// Text or HTML content to display
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
               OnChangeValue();
            }
        }

        /// <summary>
        /// Controls whether text wrap is activated or not.
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
            return "qx.ui.mobile.basic.Label";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("value", _value, null);
            state.SetPropertyValue("wrap", _wrap, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeValue()
        {
            if (ChangeValue != null)
            {
                ChangeValue.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #value}.
        /// </summary>
        public event EventHandler ChangeValue;

    }
}
