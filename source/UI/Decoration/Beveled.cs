using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// Beveled is a variant of a rounded decorator which is quite optimal regarding performance and still delivers a good set of features:   One pixel rounded border Inner glow color with optional transparency Repeated or scaled background image 
    /// </summary>
    public partial class Beveled : qxDotNet.UI.Decoration.Abstract
    {

        private string _innerColor = null;
        private decimal _innerOpacity = 1m;
        private string _outerColor = null;
        private string _backgroundImage = "";
//        private _var _backgroundPositionX = null;
//        private _var _backgroundPositionY = null;
        private qxDotNet.BackgroundRepeatEnum _backgroundRepeat = BackgroundRepeatEnum.repeat;
        private string _backgroundColor = null;


        /// <summary>
        /// The color of the inner frame.
        /// </summary>
        public string InnerColor
        {
            get
            {
                return _innerColor;
            }
            set
            {
               _innerColor = value;
            }
        }

        /// <summary>
        /// The opacity of the inner frame. As this inner frame is rendered above the background image this may be intersting to configure as semi-transparent e.g. 0.4.
        /// </summary>
        public decimal InnerOpacity
        {
            get
            {
                return _innerOpacity;
            }
            set
            {
               _innerOpacity = value;
            }
        }

        /// <summary>
        /// Color of the outer frame. The corners are automatically rendered with a slight opacity to fade into the background
        /// </summary>
        public string OuterColor
        {
            get
            {
                return _outerColor;
            }
            set
            {
               _outerColor = value;
            }
        }

        /// <summary>
        /// The URL of the background image
        /// </summary>
        public string BackgroundImage
        {
            get
            {
                return _backgroundImage;
            }
            set
            {
               _backgroundImage = value;
            }
        }

        /// <summary>
        /// How the background image should be repeated
        /// </summary>
        public qxDotNet.BackgroundRepeatEnum BackgroundRepeat
        {
            get
            {
                return _backgroundRepeat;
            }
            set
            {
               _backgroundRepeat = value;
            }
        }

        /// <summary>
        /// Color of the background
        /// </summary>
        public string BackgroundColor
        {
            get
            {
                return _backgroundColor;
            }
            set
            {
               _backgroundColor = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.Beveled";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("innerColor", _innerColor, null);
            state.SetPropertyValue("innerOpacity", _innerOpacity, 1m);
            state.SetPropertyValue("outerColor", _outerColor, null);
            state.SetPropertyValue("backgroundImage", _backgroundImage, "");
            state.SetPropertyValue("backgroundRepeat", _backgroundRepeat, BackgroundRepeatEnum.repeat);
            state.SetPropertyValue("backgroundColor", _backgroundColor, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
