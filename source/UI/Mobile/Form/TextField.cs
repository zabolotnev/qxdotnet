using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The TextField is a single-line text input field.
    /// </summary>
    public partial class TextField : qxDotNet.UI.Mobile.Form.Input, qxDotNet.UI.Form.IStringForm
    {

        private bool? _liveUpdate = false;
        private string _value = "";
        private int? _maxLength = null;
        private string _placeholder = null;
        private bool? _readOnly = null;


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
            return "qx.ui.mobile.form.TextField";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("liveUpdate", _liveUpdate, false);
            state.SetPropertyValue("maxLength", _maxLength, null);
            state.SetPropertyValue("placeholder", _placeholder, null);
            state.SetPropertyValue("readOnly", _readOnly, null);
            state.SetPropertyValue("value", _value, "");

            state.SetEvent("changeValue", false, "value");
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

    }
}
