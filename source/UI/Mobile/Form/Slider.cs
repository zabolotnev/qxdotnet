using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The Slider widget provides horizontal slider.  The Slider is the classic widget for controlling a bounded value. It lets the user move a slider handle along a horizontal groove and translates the handle's position into an integer value within the defined range. Example  Here is a little example of how to use the widget.    var slider= new qx.ui.mobile.form.Slider().set({  minimum : 0,  maximum : 10,  step : 2  });  slider.addListener(\changeValue\, handler, this);   this.getRoot.add(slider);   This example creates a slider and attaches an event listener to the {@link #changeValue} event.
    /// </summary>
    public partial class Slider : qxDotNet.UI.Mobile.Core.Widget, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IModel, qxDotNet.UI.Form.INumberForm
    {

        private qxDotNet.DisplayValueEnum _displayValue = DisplayValueEnum.percent;
        private int _maximum = 100;
        private int _minimum = 0;
        private bool? _reverseDirection = false;
        private int _step = 1;
        private bool? _liveUpdate = false;
//        private _var _value = null;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;
//        private _var _model = null;


        /// <summary>
        /// Adjusts which slider value should be displayed inside the knob. If null no value will be displayed.
        /// </summary>
        public qxDotNet.DisplayValueEnum DisplayValue
        {
            get
            {
                return _displayValue;
            }
            set
            {
               _displayValue = value;
            }
        }

        /// <summary>
        /// The maximum slider value (may be negative). This value must be larger than {@link #minimum}.
        /// </summary>
        public int Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
               _maximum = value;
               OnChangeMaximum();
            }
        }

        /// <summary>
        /// The minimum slider value (may be negative). This value must be smaller than {@link #maximum}.
        /// </summary>
        public int Minimum
        {
            get
            {
                return _minimum;
            }
            set
            {
               _minimum = value;
               OnChangeMinimum();
            }
        }

        /// <summary>
        /// Reverses the display direction of the slider knob. If true, the maxium of the slider is on the left side and minimum on the right side.
        /// </summary>
        public bool? ReverseDirection
        {
            get
            {
                return _reverseDirection;
            }
            set
            {
               _reverseDirection = value;
            }
        }

        /// <summary>
        /// The amount to increment on each event. Typically corresponds to the user moving the knob.
        /// </summary>
        public int Step
        {
            get
            {
                return _step;
            }
            set
            {
               _step = value;
               OnChangeStep();
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
            return "qx.ui.mobile.form.Slider";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("displayValue", _displayValue, DisplayValueEnum.percent);
            state.SetPropertyValue("maximum", _maximum, 100);
            state.SetPropertyValue("minimum", _minimum, 0);
            state.SetPropertyValue("reverseDirection", _reverseDirection, false);
            state.SetPropertyValue("step", _step, 1);
            state.SetPropertyValue("liveUpdate", _liveUpdate, false);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);
            state.SetPropertyValue("value", _value, 0M);

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

        protected virtual void OnChangeMaximum()
        {
            if (ChangeMaximum != null)
            {
                ChangeMaximum.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #maximum}.
        /// </summary>
        public event EventHandler ChangeMaximum;

        protected virtual void OnChangeMinimum()
        {
            if (ChangeMinimum != null)
            {
                ChangeMinimum.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #minimum}.
        /// </summary>
        public event EventHandler ChangeMinimum;

        protected virtual void OnChangeStep()
        {
            if (ChangeStep != null)
            {
                ChangeStep.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #step}.
        /// </summary>
        public event EventHandler ChangeStep;

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
