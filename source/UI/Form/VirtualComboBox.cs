using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A virtual form widget that allows text entry as well as selection from a drop-down.
    /// </summary>
    public partial class VirtualComboBox : qxDotNet.UI.Form.Core.AbstractVirtualBox, qxDotNet.UI.Form.IStringForm
    {

        private string _placeholder = "";
//        private _var _value = null;
        private string _textSelection = "";


        /// <summary>
        /// String value which will be shown as a hint if the field is all of: unset, unfocused and enabled. Set to null to not show a placeholder text.
        /// </summary>
        public string Placeholder
        {
            get
            {
                return _placeholder;
            }
            set
            {
               _placeholder = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TextSelection
        {
            get
            {
                return _textSelection;
            }
            set
            {
               _textSelection = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.VirtualComboBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("placeholder", _placeholder, "");
            state.SetPropertyValue("textSelection", _textSelection, "");

            state.SetPropertyValue("value", _value, "");


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
