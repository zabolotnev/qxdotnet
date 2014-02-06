using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Control
{
    /// <summary>
    /// A typical color selector as known from native applications.  Includes support for RGB and HSB color areas.
    /// </summary>
    public partial class ColorSelector : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IColorForm
    {

        private int _blue = 255;
        private decimal _brightness = 100m;
        private int _green = 255;
        private decimal _hue = 0m;
        private int _red = 255;
        private decimal _saturation = 0m;
        private string _value = "";


        /// <summary>
        /// The numeric blue value of the selected color.
        /// </summary>
        public int Blue
        {
            get
            {
                return _blue;
            }
            set
            {
               _blue = value;
            }
        }

        /// <summary>
        /// The numeric brightness value.
        /// </summary>
        public decimal Brightness
        {
            get
            {
                return _brightness;
            }
            set
            {
               _brightness = value;
            }
        }

        /// <summary>
        /// The numeric green value of the selected color.
        /// </summary>
        public int Green
        {
            get
            {
                return _green;
            }
            set
            {
               _green = value;
            }
        }

        /// <summary>
        /// The numeric hue value.
        /// </summary>
        public decimal Hue
        {
            get
            {
                return _hue;
            }
            set
            {
               _hue = value;
            }
        }

        /// <summary>
        /// The numeric red value of the selected color.
        /// </summary>
        public int Red
        {
            get
            {
                return _red;
            }
            set
            {
               _red = value;
            }
        }

        /// <summary>
        /// The numeric saturation value.
        /// </summary>
        public decimal Saturation
        {
            get
            {
                return _saturation;
            }
            set
            {
               _saturation = value;
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

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.control.ColorSelector";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("blue", _blue, 255);
            state.SetPropertyValue("brightness", _brightness, 100m);
            state.SetPropertyValue("green", _green, 255);
            state.SetPropertyValue("hue", _hue, 0m);
            state.SetPropertyValue("red", _red, 255);
            state.SetPropertyValue("saturation", _saturation, 0m);
            state.SetPropertyValue("value", _value, "");

            if (ChangeValue != null)
            {
                state.SetEvent("changeValue", false);
            }
            if (Dialogcancel != null)
            {
                state.SetEvent("dialogcancel", false);
            }
            if (Dialogok != null)
            {
                state.SetEvent("dialogok", false);
            }

            state.SetEvent("changeValue", false, "value");
            state.SetEvent("dialogcancel", true);
            state.SetEvent("dialogok", true);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeValue")
            {
                OnChangeValue();
            }
            if (eventName == "dialogcancel")
            {
                OnDialogcancel();
            }
            if (eventName == "dialogok")
            {
                OnDialogok();
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
        /// Fired when the value changes
        /// </summary>
        public event EventHandler ChangeValue;

        protected virtual void OnDialogcancel()
        {
            if (Dialogcancel != null)
            {
                Dialogcancel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the "Cancel" button is clicked.
        /// </summary>
        public event EventHandler Dialogcancel;

        protected virtual void OnDialogok()
        {
            if (Dialogok != null)
            {
                Dialogok.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the "OK" button is clicked.
        /// </summary>
        public event EventHandler Dialogok;

    }
}
