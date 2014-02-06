using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Basically a text fields which allows a selection from a list of preconfigured options. Allows custom user input. Public API is value oriented.  To work with selections without custom input the ideal candidates are the {@link SelectBox} or the {@link RadioGroup}.
    /// </summary>
    public partial class ComboBox : qxDotNet.UI.Form.AbstractSelectBox, qxDotNet.UI.Form.IStringForm
    {

        private string _placeholder = "";
        private string _textSelection = "";
//        private _var _value = null;


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
            return "qx.ui.form.ComboBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("placeholder", _placeholder, "");
            state.SetPropertyValue("textSelection", _textSelection, "");

            state.SetPropertyValue("value", _value, "");

            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", true, "value");
            }
            else
            {
                state.SetEvent("changeValue", false, "value");
            }


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeValue")
            {
                OnChangeValue();
            }
        }

        protected virtual void OnChangeValue()
        {
            if (ChangeValue != null)
            {
                ChangeValue.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Whenever the value is changed this event is fired  Event data: The new text value of the field.
        /// </summary>
        public event EventHandler ChangeValue;

    }
}
