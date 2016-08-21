using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// This is a basic form field with common functionality for
    /// {@link TextArea} and {@link TextField}.
    /// 
    /// On every keystroke the value is synchronized with the
    /// value of the textfield. Value changes can be monitored by listening to the
    /// {@link #input} or {@link #changeValue} events, respectively.
    /// 
    /// </summary>
    public abstract partial class AbstractField : qxDotNet.UI.Core.ChildrenHandling, qxDotNet.UI.Form.IStringForm, qxDotNet.UI.Form.IForm
    {

        private string _filter = null;
        private bool? _liveUpdate = false;
        private int _maxLength = int.MaxValue;
        private string _placeholder = "";
        private bool? _readOnly = false;
        private qxDotNet.TextAlignEnum _textAlign = (TextAlignEnum)(-1);
        private string _value = "";
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// RegExp responsible for filtering the value of the textfield. the RegExp
        /// gives the range of valid values.
        /// The following example only allows digits in the textfield.
        /// 
        /// field.setFilter(/[0-9]/);
        /// </summary>
        public string Filter
        {
            get
            {
                return _filter;
            }
            set
            {
               _filter = value;
            }
        }

        /// <summary>
        /// Whether the {@link #changeValue} event should be fired on every key
        /// input. If set to true, the changeValue event is equal to the
        /// {@link #input} event.
        /// 
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
        /// Maximal number of characters that can be entered in the TextArea.
        /// 
        /// </summary>
        public int MaxLength
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
        /// String value which will be shown as a hint if the field is all of:
        /// unset, unfocused and enabled. Set to null to not show a placeholder
        /// text.
        /// 
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
        /// 
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
               OnChangeReadOnly();
            }
        }

        /// <summary>
        /// Alignment of the text
        /// 
        /// </summary>
        public qxDotNet.TextAlignEnum TextAlign
        {
            get
            {
                return _textAlign;
            }
            set
            {
               _textAlign = value;
            }
        }

        /// <summary>
        /// Returns the current value of the textfield.
        /// 
        /// Sets the value of the textfield to the given value.
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
        /// Message which is shown in an invalid tooltip.
        /// 
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
        /// 
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
        /// Message which is shown in an invalid tooltip if the {@link #required} is
        /// set to true.
        /// 
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
        /// Flag signaling if a widget is valid. If a widget is invalid, an invalid
        /// state will be set.
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.AbstractField";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("filter", _filter, null);
            state.SetPropertyValue("liveUpdate", _liveUpdate, false);
            state.SetPropertyValue("maxLength", _maxLength, int.MaxValue);
            state.SetPropertyValue("placeholder", _placeholder, "");
            state.SetPropertyValue("readOnly", _readOnly, false);
            state.SetPropertyValue("textAlign", _textAlign, (TextAlignEnum)(-1));
            state.SetPropertyValue("value", _value, "");
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);

            state.SetEvent("changeValue", false, "value");
            if (Input != null)
            {
                state.SetEvent("input", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
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

        /// <summary>
        /// Raises event 'ChangeReadOnly'
        /// </summary>
        protected virtual void OnChangeReadOnly()
        {
            if (ChangeReadOnly != null)
            {
                ChangeReadOnly.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #readOnly}.
        /// </summary>
        public event EventHandler ChangeReadOnly;

        /// <summary>
        /// Raises event 'ChangeValue'
        /// </summary>
        protected virtual void OnChangeValue()
        {
            if (ChangeValue != null)
            {
                ChangeValue.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired each time the text field looses focus and the
        /// text field values has changed.
        /// 
        /// If you change {@link #liveUpdate} to true, the changeValue event will
        /// be fired after every keystroke and not only after every focus loss. In
        /// that mode, the changeValue event is equal to the {@link #input} event.
        /// 
        /// The method {@link qx.event.type.Data#getData} returns the
        /// current text value of the field.
        /// 
        /// </summary>
        public event EventHandler ChangeValue;

        /// <summary>
        /// Raises event 'Input'
        /// </summary>
        protected virtual void OnInput()
        {
            if (Input != null)
            {
                Input.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The event is fired on every keystroke modifying the value of the field.
        /// 
        /// The method {@link qx.event.type.Data#getData} returns the
        /// current value of the text field.
        /// 
        /// </summary>
        public event EventHandler Input;

        /// <summary>
        /// Raises event 'ChangeInvalidMessage'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeRequired'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeValid'
        /// </summary>
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
