using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The Slider widget provides a vertical or horizontal slider.
    /// 
    /// The Slider is the classic widget for controlling a bounded value.
    /// It lets the user move a slider handle along a horizontal or vertical
    /// groove and translates the handle's position into an integer value
    /// within the defined range.
    /// 
    /// The Slider has very few of its own functions.
    /// The most useful functions are slideTo() to set the slider directly to some
    /// value; setSingleStep(), setPageStep() to set the steps; and setMinimum()
    /// and setMaximum() to define the range of the slider.
    /// 
    /// A slider accepts focus on Tab and provides both a mouse wheel and
    /// a keyboard interface. The keyboard interface is the following:
    /// 
    /// 
    /// Left/Right move a horizontal slider by one single step.
    /// Up/Down move a vertical slider by one single step.
    /// PageUp moves up one page.
    /// PageDown moves down one page.
    /// Home moves to the start (minimum).
    /// End moves to the end (maximum).
    /// 
    /// 
    /// Here are the main properties of the class:
    /// 
    /// 
    /// value: The bounded integer that {@link qx.ui.form.INumberForm}
    /// maintains.
    /// minimum: The lowest possible value.
    /// maximum: The highest possible value.
    /// singleStep: The smaller of two natural steps that an abstract
    /// sliders provides and typically corresponds to the user pressing an arrow key.
    /// pageStep: The larger of two natural steps that an abstract
    /// slider provides and typically corresponds to the user pressing PageUp or
    /// PageDown.
    /// 
    /// </summary>
    public partial class Slider : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IRange
    {

        private decimal _knobFactor = 0m;
        private int _maximum = 100;
        private int _minimum = 0;
        private qxDotNet.OrientationEnum _orientation = OrientationEnum.horizontal;
        private int _pageStep = 10;
        private int _singleStep = 1;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// Factor to apply to the width/height of the knob in relation
        /// to the dimension of the underlying area.
        /// 
        /// </summary>
        public decimal KnobFactor
        {
            get
            {
                return _knobFactor;
            }
            set
            {
               _knobFactor = value;
            }
        }

        /// <summary>
        /// The maximum slider value (may be negative). This value must be larger
        /// than {@link #minimum}.
        /// 
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
        /// The minimum slider value (may be negative). This value must be smaller
        /// than {@link #maximum}.
        /// 
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
        /// Whether the slider is horizontal or vertical.
        /// 
        /// </summary>
        public qxDotNet.OrientationEnum Orientation
        {
            get
            {
                return _orientation;
            }
            set
            {
               _orientation = value;
            }
        }

        /// <summary>
        /// The amount to increment on each event. Typically corresponds
        /// to the user pressing PageUp or PageDown.
        /// 
        /// </summary>
        public int PageStep
        {
            get
            {
                return _pageStep;
            }
            set
            {
               _pageStep = value;
            }
        }

        /// <summary>
        /// The amount to increment on each event. Typically corresponds
        /// to the user pressing an arrow key.
        /// 
        /// </summary>
        public int SingleStep
        {
            get
            {
                return _singleStep;
            }
            set
            {
               _singleStep = value;
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
            return "qx.ui.form.Slider";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("knobFactor", _knobFactor, 0m);
            state.SetPropertyValue("maximum", _maximum, 100);
            state.SetPropertyValue("minimum", _minimum, 0);
            state.SetPropertyValue("orientation", _orientation, OrientationEnum.horizontal);
            state.SetPropertyValue("pageStep", _pageStep, 10);
            state.SetPropertyValue("singleStep", _singleStep, 1);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);

            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", false);
            }
            if (SlideAnimationEnd != null)
            {
                state.SetEvent("slideAnimationEnd", false);
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
            if (eventName == "slideAnimationEnd")
            {
                OnSlideAnimationEnd();
            }
        }

        /// <summary>
        /// Raises event 'ChangeMaximum'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeMinimum'
        /// </summary>
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
        /// Change event for the value.
        /// 
        /// </summary>
        public event EventHandler ChangeValue;

        /// <summary>
        /// Raises event 'SlideAnimationEnd'
        /// </summary>
        protected virtual void OnSlideAnimationEnd()
        {
            if (SlideAnimationEnd != null)
            {
                SlideAnimationEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired as soon as the slide animation ended.
        /// 
        /// </summary>
        public event EventHandler SlideAnimationEnd;

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
