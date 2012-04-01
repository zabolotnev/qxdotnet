using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A date field is like a combo box with the date as popup. As button to open the calendar a calendar icon is shown at the right to the textfield.  To be conform with all form widgets, the {@link qx.ui.form.IForm} interface is implemented.  The following example creates a date field and sets the current date as selected.   var dateField = new qx.ui.form.DateField(); this.getRoot().add(dateField, {top: 20, left: 20}); dateField.setValue(new Date()); 
    /// </summary>
    public partial class DateField : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IDateForm
    {

        private qxDotNet.Util.Format.DateFormat _dateFormat = null;
        private string _placeholder = "";
        private DateTime? _value = null;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// The formatter, which converts the selected date to a string. *
        /// </summary>
        public qxDotNet.Util.Format.DateFormat DateFormat
        {
            get
            {
                return _dateFormat;
            }
            set
            {
               _dateFormat = value;
            }
        }

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
        public DateTime? Value
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
        /// Message which is shown in an invalid tooltip.
        /// </summary>
        public string InvalidMessage
        {
            get
            {
                return _invalidMessage;
            }
            set
            {
               _invalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is required.
        /// </summary>
        public bool? Required
        {
            get
            {
                return _required;
            }
            set
            {
               _required = value;
               OnChangeRequired();
            }
        }

        /// <summary>
        /// Message which is shown in an invalid tooltip if the {@link #required} is set to true.
        /// </summary>
        public string RequiredInvalidMessage
        {
            get
            {
                return _requiredInvalidMessage;
            }
            set
            {
               _requiredInvalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is valid. If a widget is invalid, an invalid state will be set.
        /// </summary>
        public bool? Valid
        {
            get
            {
                return _valid;
            }
            set
            {
               _valid = value;
               OnChangeValid();
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.DateField";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("dateFormat", _dateFormat, null);
            state.SetPropertyValue("placeholder", _placeholder, "");
            state.SetPropertyValue("value", _value, null);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);

            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", false);
            }

            state.SetEvent("changeValue", false, "value");

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

        protected virtual void OnChangeInvalidMessage()
        {
            if (ChangeInvalidMessage != null)
            {
                ChangeInvalidMessage.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #invalidMessage}.
        /// </summary>
        public event EventHandler ChangeInvalidMessage;

        protected virtual void OnChangeRequired()
        {
            if (ChangeRequired != null)
            {
                ChangeRequired.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #required}.
        /// </summary>
        public event EventHandler ChangeRequired;

        protected virtual void OnChangeValid()
        {
            if (ChangeValid != null)
            {
                ChangeValid.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #valid}.
        /// </summary>
        public event EventHandler ChangeValid;

    }
}
