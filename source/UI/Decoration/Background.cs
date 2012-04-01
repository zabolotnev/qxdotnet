using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// A very simple decorator featuring background images and colors. No border is supported.
    /// </summary>
    public partial class Background : qxDotNet.UI.Decoration.Abstract
    {

        private string _backgroundImage = "";
//        private _var _backgroundPositionX = null;
//        private _var _backgroundPositionY = null;
        private qxDotNet.BackgroundRepeatEnum _backgroundRepeat = BackgroundRepeatEnum.repeat;
        private string _backgroundColor = null;


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
            return "qx.ui.decoration.Background";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
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
