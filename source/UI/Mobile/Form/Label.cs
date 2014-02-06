using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The label widget displays a text or HTML content in form context.  It uses the html tag , for making it possible to set the "for" attribute.  The "for" attribute specifies which form element a label is bound to. A tap on the label is forwarded to the bound element.  Example  Here is a little example of how to use the widget.    var checkBox = new qx.ui.mobile.form.CheckBox();  var label = new qx.ui.mobile.form.Label(\LabelforCheckBox\);   label.setLabelFor(checkBox.getId());   this.getRoot().add(label);  this.getRoot().add(checkBox);   This example create a widget to display the label.
    /// </summary>
    public partial class Label : qxDotNet.UI.Mobile.Core.Widget
    {

//        private _var _value = null;
        private bool? _wrap = true;


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
            return "qx.ui.mobile.form.Label";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
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
