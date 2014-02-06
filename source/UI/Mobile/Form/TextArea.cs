using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The TextArea is a multi-line text input field.
    /// </summary>
    public partial class TextArea : qxDotNet.UI.Mobile.Core.Widget, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IModel
    {

        private bool? _liveUpdate = false;
//        private _var _value = null;
        private int? _maxLength = null;
        private string _placeholder = null;
        private bool? _readOnly = null;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;
//        private _var _model = null;


        /// <summary>
        /// Whether the {@link #changeValue} event should be fired on every key input. If set to true, the changeValue event is equal to the {@link #input} event.
        /// </summary>
        public bool? LiveUpdate
        {
            get
            {
                return _liveUpdate;
            }
            set
            {
               _liveUpdate = value;
            }
        }

        /// <summary>
        /// Maximal number of characters that can be entered in the input field.
        /// </summary>
        public int? MaxLength
        {
            get
            {
                return _maxLength;
            }
            set
            {
               _maxLength = value;
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
        /// Whether the field is read only
        /// </summary>
        public bool? ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
               _readOnly = value;
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


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.TextArea";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("liveUpdate", _liveUpdate, false);
            state.SetPropertyValue("maxLength", _maxLength, null);
            state.SetPropertyValue("placeholder", _placeholder, null);
            state.SetPropertyValue("readOnly", _readOnly, null);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);

            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", false);
            }
            if (Input != null)
            {
                state.SetEvent("input", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeValue")
            {
                OnChangeValue();
            }
            if (eventName == "input")
            {
                OnInput();
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
        /// The event is fired each time the text field looses focus and the text field values has changed.  If you change {@link #liveUpdate} to true, the changeValue event will be fired after every keystroke and not only after every focus loss. In that mode, the changeValue event is equal to the {@link #input} event.  The method {@link qx.event.type.Data#getData} returns the current text value of the field.
        /// </summary>
        public event EventHandler ChangeValue;

        protected virtual void OnInput()
        {
            if (Input != null)
            {
                Input.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired on every keystroke modifying the value of the field.  The method {@link qx.event.type.Data#getData} returns the current value of the text field.
        /// </summary>
        public event EventHandler Input;

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

        protected virtual void OnChangeModel()
        {
            if (ChangeModel != null)
            {
                ChangeModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #model}.
        /// </summary>
        public event EventHandler ChangeModel;

    }
}
