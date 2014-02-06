using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The NumberField is a single-line number input field. It uses HTML5 input field type "number" and the attribute "min" ,"max" and "step". The attributes can be used for form validation {@link qx.ui.form.validation.Manager}.
    /// </summary>
    public partial class NumberField : qxDotNet.UI.Mobile.Form.Input
    {

        private int? _maximum = null;
        private int? _minimum = null;
        private int? _step = null;
        private bool? _liveUpdate = false;
//        private _var _value = null;
        private int? _maxLength = null;
        private string _placeholder = null;
        private bool? _readOnly = null;


        /// <summary>
        /// The maximum text field value (may be negative). This value must be larger than {@link #maximum}.
        /// </summary>
        public int? Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
               _maximum = value;
            }
        }

        /// <summary>
        /// The minimum text field value (may be negative). This value must be smaller than {@link #minimum}.
        /// </summary>
        public int? Minimum
        {
            get
            {
                return _minimum;
            }
            set
            {
               _minimum = value;
            }
        }

        /// <summary>
        /// The amount to increment on each event.
        /// </summary>
        public int? Step
        {
            get
            {
                return _step;
            }
            set
            {
               _step = value;
            }
        }

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


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.NumberField";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("maximum", _maximum, "");
            state.SetPropertyValue("minimum", _minimum, "");
            state.SetPropertyValue("step", _step, "");
            state.SetPropertyValue("liveUpdate", _liveUpdate, false);
            state.SetPropertyValue("maxLength", _maxLength, null);
            state.SetPropertyValue("placeholder", _placeholder, null);
            state.SetPropertyValue("readOnly", _readOnly, null);

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

    }
}
