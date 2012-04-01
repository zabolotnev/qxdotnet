using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// A basic decorator featuring background colors and simple borders based on CSS styles.
    /// </summary>
    public partial class Single : qxDotNet.UI.Decoration.Abstract
    {

        private string _backgroundImage = "";
//        private _var _backgroundPositionX = null;
//        private _var _backgroundPositionY = null;
        private qxDotNet.BackgroundRepeatEnum _backgroundRepeat = BackgroundRepeatEnum.repeat;
        private string _backgroundColor = null;
        private string _colorBottom = null;
        private string _colorLeft = null;
        private string _colorRight = null;
        private string _colorTop = null;
        private qxDotNet.StyleEnum _styleBottom = StyleEnum.solid;
        private qxDotNet.StyleEnum _styleLeft = StyleEnum.solid;
        private qxDotNet.StyleEnum _styleRight = StyleEnum.solid;
        private qxDotNet.StyleEnum _styleTop = StyleEnum.solid;
        private decimal _widthBottom = 0m;
        private decimal _widthLeft = 0m;
        private decimal _widthRight = 0m;
        private decimal _widthTop = 0m;


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
        /// bottom color of border
        /// </summary>
        public string ColorBottom
        {
            get
            {
                return _colorBottom;
            }
            set
            {
               _colorBottom = value;
            }
        }

        /// <summary>
        /// left color of border
        /// </summary>
        public string ColorLeft
        {
            get
            {
                return _colorLeft;
            }
            set
            {
               _colorLeft = value;
            }
        }

        /// <summary>
        /// right color of border
        /// </summary>
        public string ColorRight
        {
            get
            {
                return _colorRight;
            }
            set
            {
               _colorRight = value;
            }
        }

        /// <summary>
        /// top color of border
        /// </summary>
        public string ColorTop
        {
            get
            {
                return _colorTop;
            }
            set
            {
               _colorTop = value;
            }
        }

        /// <summary>
        /// bottom style of border
        /// </summary>
        public qxDotNet.StyleEnum StyleBottom
        {
            get
            {
                return _styleBottom;
            }
            set
            {
               _styleBottom = value;
            }
        }

        /// <summary>
        /// left style of border
        /// </summary>
        public qxDotNet.StyleEnum StyleLeft
        {
            get
            {
                return _styleLeft;
            }
            set
            {
               _styleLeft = value;
            }
        }

        /// <summary>
        /// right style of border
        /// </summary>
        public qxDotNet.StyleEnum StyleRight
        {
            get
            {
                return _styleRight;
            }
            set
            {
               _styleRight = value;
            }
        }

        /// <summary>
        /// top style of border
        /// </summary>
        public qxDotNet.StyleEnum StyleTop
        {
            get
            {
                return _styleTop;
            }
            set
            {
               _styleTop = value;
            }
        }

        /// <summary>
        /// bottom width of border
        /// </summary>
        public decimal WidthBottom
        {
            get
            {
                return _widthBottom;
            }
            set
            {
               _widthBottom = value;
            }
        }

        /// <summary>
        /// left width of border
        /// </summary>
        public decimal WidthLeft
        {
            get
            {
                return _widthLeft;
            }
            set
            {
               _widthLeft = value;
            }
        }

        /// <summary>
        /// right width of border
        /// </summary>
        public decimal WidthRight
        {
            get
            {
                return _widthRight;
            }
            set
            {
               _widthRight = value;
            }
        }

        /// <summary>
        /// top width of border
        /// </summary>
        public decimal WidthTop
        {
            get
            {
                return _widthTop;
            }
            set
            {
               _widthTop = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.Single";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("backgroundImage", _backgroundImage, "");
            state.SetPropertyValue("backgroundRepeat", _backgroundRepeat, BackgroundRepeatEnum.repeat);
            state.SetPropertyValue("backgroundColor", _backgroundColor, null);
            state.SetPropertyValue("colorBottom", _colorBottom, null);
            state.SetPropertyValue("colorLeft", _colorLeft, null);
            state.SetPropertyValue("colorRight", _colorRight, null);
            state.SetPropertyValue("colorTop", _colorTop, null);
            state.SetPropertyValue("styleBottom", _styleBottom, StyleEnum.solid);
            state.SetPropertyValue("styleLeft", _styleLeft, StyleEnum.solid);
            state.SetPropertyValue("styleRight", _styleRight, StyleEnum.solid);
            state.SetPropertyValue("styleTop", _styleTop, StyleEnum.solid);
            state.SetPropertyValue("widthBottom", _widthBottom, 0m);
            state.SetPropertyValue("widthLeft", _widthLeft, 0m);
            state.SetPropertyValue("widthRight", _widthRight, 0m);
            state.SetPropertyValue("widthTop", _widthTop, 0m);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
