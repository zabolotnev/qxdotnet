using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Control
{
    /// <summary>
    /// A typical color selector as known from native applications.
    /// 
    /// Includes support for RGB and HSB color areas.
    /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// Returns the currently selected color.
        /// 
        /// The value of the ColorSelector is a string containing the HEX value of
        /// the currently selected color. Take a look at
        /// {@link qx.util.ColorUtil#stringToRgb} to see what kind of input the
        /// method can handle.
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.control.ColorSelector";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
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

            state.SetEvent("changeValue", false, "value");
            if (Dialogcancel != null)
            {
                state.SetEvent("dialogcancel", true);
            }
            if (Dialogok != null)
            {
                state.SetEvent("dialogok", true);
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
            if (eventName == "dialogcancel")
            {
                OnDialogcancel();
            }
            if (eventName == "dialogok")
            {
                OnDialogok();
            }
        }

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
        /// Fired when the value changes
        /// 
        /// </summary>
        public event EventHandler ChangeValue;

        /// <summary>
        /// Raises event 'Dialogcancel'
        /// </summary>
        protected virtual void OnDialogcancel()
        {
            if (Dialogcancel != null)
            {
                Dialogcancel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the "Cancel" button is tapped.
        /// 
        /// </summary>
        public event EventHandler Dialogcancel;

        /// <summary>
        /// Raises event 'Dialogok'
        /// </summary>
        protected virtual void OnDialogok()
        {
            if (Dialogok != null)
            {
                Dialogok.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the "OK" button is tapped.
        /// 
        /// </summary>
        public event EventHandler Dialogok;

    }
}
