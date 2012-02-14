using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A spinner is a control that allows you to adjust a numerical value, typically within an allowed range. An obvious example would be to specify the month of a year as a number in the range 1 &#8211; 12.  To do so, a spinner encompasses a field to display the current value (a textfield) and controls such as up and down buttons to change that value. The current value can also be changed by editing the display field directly, or using mouse wheel and cursor keys.  An optional {@link #numberFormat} property allows you to control the format of how a value can be entered and will be displayed.  A brief, but non-trivial example:   var s = new qx.ui.form.Spinner(); s.set({  maximum: 3000,  minimum: -3000 }); var nf = new qx.util.format.NumberFormat(); nf.setMaximumFractionDigits(2); s.setNumberFormat(nf);   A spinner instance without any further properties specified in the constructor or a subsequent set command will appear with default values and behaviour.
    /// </summary>
    public partial class Spinner : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.INumberForm, qxDotNet.UI.Form.IRange, qxDotNet.UI.Form.IForm
    {

        private bool? _editable = true;
        private decimal _maximum = 100;
        private decimal _minimum = 0;
        private qxDotNet.Util.Format.NumberFormat _numberFormat = null;
        private decimal _pageStep = 10;
        private decimal _singleStep = 1;
//        private _var _value = 0;
        private bool? _wrap = false;
        private int _contentPaddingBottom = 0;
        private int _contentPaddingLeft = 0;
        private int _contentPaddingRight = 0;
        private int _contentPaddingTop = 0;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// Controls whether the textfield of the spinner is editable or not
        /// </summary>
        public bool? Editable
        {
            get
            {
                return _editable;
            }
            set
            {
               _editable = value;
            }
        }

        /// <summary>
        /// maximal value of the Range object
        /// </summary>
        public decimal Maximum
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
        /// minimal value of the Range object
        /// </summary>
        public decimal Minimum
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
        /// Controls the display of the number in the textfield
        /// </summary>
        public qxDotNet.Util.Format.NumberFormat NumberFormat
        {
            get
            {
                return _numberFormat;
            }
            set
            {
               _numberFormat = value;
            }
        }

        /// <summary>
        /// The amount to increment on each pageup/pagedown keypress
        /// </summary>
        public decimal PageStep
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
        /// The amount to increment on each event (keypress or mousedown)
        /// </summary>
        public decimal SingleStep
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
        /// whether the value should wrap around
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

        /// <summary>
        /// Bottom padding of the content pane
        /// </summary>
        public int ContentPaddingBottom
        {
            get
            {
                return _contentPaddingBottom;
            }
            set
            {
               _contentPaddingBottom = value;
            }
        }

        /// <summary>
        /// Left padding of the content pane
        /// </summary>
        public int ContentPaddingLeft
        {
            get
            {
                return _contentPaddingLeft;
            }
            set
            {
               _contentPaddingLeft = value;
            }
        }

        /// <summary>
        /// Right padding of the content pane
        /// </summary>
        public int ContentPaddingRight
        {
            get
            {
                return _contentPaddingRight;
            }
            set
            {
               _contentPaddingRight = value;
            }
        }

        /// <summary>
        /// Top padding of the content pane
        /// </summary>
        public int ContentPaddingTop
        {
            get
            {
                return _contentPaddingTop;
            }
            set
            {
               _contentPaddingTop = value;
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


        public override string GetTypeName()
        {
            return "qx.ui.form.Spinner";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("editable", _editable, true);
            state.SetPropertyValue("maximum", _maximum, 100);
            state.SetPropertyValue("minimum", _minimum, 0);
            state.SetPropertyValue("numberFormat", _numberFormat, null);
            state.SetPropertyValue("pageStep", _pageStep, 10);
            state.SetPropertyValue("singleStep", _singleStep, 1);
            state.SetPropertyValue("wrap", _wrap, false);
            state.SetPropertyValue("contentPaddingBottom", _contentPaddingBottom, 0);
            state.SetPropertyValue("contentPaddingLeft", _contentPaddingLeft, 0);
            state.SetPropertyValue("contentPaddingRight", _contentPaddingRight, 0);
            state.SetPropertyValue("contentPaddingTop", _contentPaddingTop, 0);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);

            state.SetPropertyValue("value", _value, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
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
