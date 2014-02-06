using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// Decorator including all decoration possibilities from mixins:   Background color Background image Background gradient Single and double borders Border radius Box shadow 
    /// </summary>
    public partial class Decorator : qxDotNet.UI.Decoration.Abstract, qxDotNet.UI.Decoration.IDecorator
    {

        private string _backgroundColor = null;
        private int _radiusBottomLeft = 0;
        private int _radiusBottomRight = 0;
        private int _radiusTopLeft = 0;
        private int _radiusTopRight = 0;
        private bool? _inset = false;
        private int _shadowBlurRadius = 0;
        private string _shadowColor = null;
        private int _shadowHorizontalLength = 0;
        private int _shadowSpreadRadius = 0;
        private int _shadowVerticalLength = 0;
        private string _innerColorBottom = null;
        private string _innerColorLeft = null;
        private string _innerColorRight = null;
        private string _innerColorTop = null;
        private decimal _innerOpacity = 1;
        private decimal _innerWidthBottom = 0;
        private decimal _innerWidthLeft = 0;
        private decimal _innerWidthRight = 0;
        private decimal _innerWidthTop = 0;
        private qxDotNet.ColorPositionUnitEnum _colorPositionUnit = ColorPositionUnitEnum.percent;
        private string _endColor = null;
        private decimal _endColorPosition = 100;
        private qxDotNet.OrientationEnum _orientation = OrientationEnum.vertical;
        private string _startColor = null;
        private decimal _startColorPosition = 0;
        private string _borderImage = "";
        private qxDotNet.BorderImageModeEnum _borderImageMode = BorderImageModeEnum.grid;
        private bool? _fill = true;
        private qxDotNet.RepeatEnum _repeatX = RepeatEnum.stretch;
        private qxDotNet.RepeatEnum _repeatY = RepeatEnum.stretch;
        private int _sliceBottom = 0;
        private int _sliceLeft = 0;
        private int _sliceRight = 0;
        private int _sliceTop = 0;


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
        /// bottom left corner radius
        /// </summary>
        public int RadiusBottomLeft
        {
            get
            {
                return _radiusBottomLeft;
            }
            set
            {
               _radiusBottomLeft = value;
            }
        }

        /// <summary>
        /// bottom right corner radius
        /// </summary>
        public int RadiusBottomRight
        {
            get
            {
                return _radiusBottomRight;
            }
            set
            {
               _radiusBottomRight = value;
            }
        }

        /// <summary>
        /// top left corner radius
        /// </summary>
        public int RadiusTopLeft
        {
            get
            {
                return _radiusTopLeft;
            }
            set
            {
               _radiusTopLeft = value;
            }
        }

        /// <summary>
        /// top right corner radius
        /// </summary>
        public int RadiusTopRight
        {
            get
            {
                return _radiusTopRight;
            }
            set
            {
               _radiusTopRight = value;
            }
        }

        /// <summary>
        /// Inset shadows are drawn inside the border.
        /// </summary>
        public bool? Inset
        {
            get
            {
                return _inset;
            }
            set
            {
               _inset = value;
            }
        }

        /// <summary>
        /// The blur radius of the shadow.
        /// </summary>
        public int ShadowBlurRadius
        {
            get
            {
                return _shadowBlurRadius;
            }
            set
            {
               _shadowBlurRadius = value;
            }
        }

        /// <summary>
        /// The color of the shadow.
        /// </summary>
        public string ShadowColor
        {
            get
            {
                return _shadowColor;
            }
            set
            {
               _shadowColor = value;
            }
        }

        /// <summary>
        /// Horizontal length of the shadow.
        /// </summary>
        public int ShadowHorizontalLength
        {
            get
            {
                return _shadowHorizontalLength;
            }
            set
            {
               _shadowHorizontalLength = value;
            }
        }

        /// <summary>
        /// The spread radius of the shadow.
        /// </summary>
        public int ShadowSpreadRadius
        {
            get
            {
                return _shadowSpreadRadius;
            }
            set
            {
               _shadowSpreadRadius = value;
            }
        }

        /// <summary>
        /// Vertical length of the shadow.
        /// </summary>
        public int ShadowVerticalLength
        {
            get
            {
                return _shadowVerticalLength;
            }
            set
            {
               _shadowVerticalLength = value;
            }
        }

        /// <summary>
        /// bottom inner color of border
        /// </summary>
        public string InnerColorBottom
        {
            get
            {
                return _innerColorBottom;
            }
            set
            {
               _innerColorBottom = value;
            }
        }

        /// <summary>
        /// left inner color of border
        /// </summary>
        public string InnerColorLeft
        {
            get
            {
                return _innerColorLeft;
            }
            set
            {
               _innerColorLeft = value;
            }
        }

        /// <summary>
        /// right inner color of border
        /// </summary>
        public string InnerColorRight
        {
            get
            {
                return _innerColorRight;
            }
            set
            {
               _innerColorRight = value;
            }
        }

        /// <summary>
        /// top inner color of border
        /// </summary>
        public string InnerColorTop
        {
            get
            {
                return _innerColorTop;
            }
            set
            {
               _innerColorTop = value;
            }
        }

        /// <summary>
        /// The opacity of the inner border.
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
        /// bottom width of border
        /// </summary>
        public decimal InnerWidthBottom
        {
            get
            {
                return _innerWidthBottom;
            }
            set
            {
               _innerWidthBottom = value;
            }
        }

        /// <summary>
        /// left width of border
        /// </summary>
        public decimal InnerWidthLeft
        {
            get
            {
                return _innerWidthLeft;
            }
            set
            {
               _innerWidthLeft = value;
            }
        }

        /// <summary>
        /// right width of border
        /// </summary>
        public decimal InnerWidthRight
        {
            get
            {
                return _innerWidthRight;
            }
            set
            {
               _innerWidthRight = value;
            }
        }

        /// <summary>
        /// top width of border
        /// </summary>
        public decimal InnerWidthTop
        {
            get
            {
                return _innerWidthTop;
            }
            set
            {
               _innerWidthTop = value;
            }
        }

        /// <summary>
        /// Defines if the given positions are in % or px.
        /// </summary>
        public qxDotNet.ColorPositionUnitEnum ColorPositionUnit
        {
            get
            {
                return _colorPositionUnit;
            }
            set
            {
               _colorPositionUnit = value;
            }
        }

        /// <summary>
        /// End color of the background gradient. Note that alpha transparency (rgba) is not supported in IE 8.
        /// </summary>
        public string EndColor
        {
            get
            {
                return _endColor;
            }
            set
            {
               _endColor = value;
            }
        }

        /// <summary>
        /// Position in percent where to start the color.
        /// </summary>
        public decimal EndColorPosition
        {
            get
            {
                return _endColorPosition;
            }
            set
            {
               _endColorPosition = value;
            }
        }

        /// <summary>
        /// The orientation of the gradient.
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
        /// Start color of the background gradient. Note that alpha transparency (rgba) is not supported in IE 8.
        /// </summary>
        public string StartColor
        {
            get
            {
                return _startColor;
            }
            set
            {
               _startColor = value;
            }
        }

        /// <summary>
        /// Position in percent where to start the color.
        /// </summary>
        public decimal StartColorPosition
        {
            get
            {
                return _startColorPosition;
            }
            set
            {
               _startColorPosition = value;
            }
        }

        /// <summary>
        /// Base image URL.
        /// </summary>
        public string BorderImage
        {
            get
            {
                return _borderImage;
            }
            set
            {
               _borderImage = value;
            }
        }

        /// <summary>
        /// Configures the border image mode. Supported values:   horizontal: left and right border images  vertical: top and bottom border images  grid: border images for all edges 
        /// </summary>
        public qxDotNet.BorderImageModeEnum BorderImageMode
        {
            get
            {
                return _borderImageMode;
            }
            set
            {
               _borderImageMode = value;
            }
        }

        /// <summary>
        /// If set to false, the center image will be omitted and only the border will be drawn.
        /// </summary>
        public bool? Fill
        {
            get
            {
                return _fill;
            }
            set
            {
               _fill = value;
            }
        }

        /// <summary>
        /// This property specifies how the images for the sides and the middle part of the border image are scaled and tiled horizontally.  Values have the following meanings:   stretch: The image is stretched to fill the area.  repeat: The image is tiled (repeated) to fill the area.  round: The image is tiled (repeated) to fill the area. If it does not  fill the area with a whole number of tiles, the image is rescaled so  that it does. 
        /// </summary>
        public qxDotNet.RepeatEnum RepeatX
        {
            get
            {
                return _repeatX;
            }
            set
            {
               _repeatX = value;
            }
        }

        /// <summary>
        /// This property specifies how the images for the sides and the middle part of the border image are scaled and tiled vertically.  Values have the following meanings:   stretch: The image is stretched to fill the area.  repeat: The image is tiled (repeated) to fill the area.  round: The image is tiled (repeated) to fill the area. If it does not  fill the area with a whole number of tiles, the image is rescaled so  that it does. 
        /// </summary>
        public qxDotNet.RepeatEnum RepeatY
        {
            get
            {
                return _repeatY;
            }
            set
            {
               _repeatY = value;
            }
        }

        /// <summary>
        /// The bottom slice line of the base image. The slice properties divide the image into nine regions, which define the corner, edge and the center images.
        /// </summary>
        public int SliceBottom
        {
            get
            {
                return _sliceBottom;
            }
            set
            {
               _sliceBottom = value;
            }
        }

        /// <summary>
        /// The left slice line of the base image. The slice properties divide the image into nine regions, which define the corner, edge and the center images.
        /// </summary>
        public int SliceLeft
        {
            get
            {
                return _sliceLeft;
            }
            set
            {
               _sliceLeft = value;
            }
        }

        /// <summary>
        /// The right slice line of the base image. The slice properties divide the image into nine regions, which define the corner, edge and the center images.
        /// </summary>
        public int SliceRight
        {
            get
            {
                return _sliceRight;
            }
            set
            {
               _sliceRight = value;
            }
        }

        /// <summary>
        /// The top slice line of the base image. The slice properties divide the image into nine regions, which define the corner, edge and the center images.
        /// </summary>
        public int SliceTop
        {
            get
            {
                return _sliceTop;
            }
            set
            {
               _sliceTop = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.Decorator";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("backgroundColor", _backgroundColor, null);
            state.SetPropertyValue("radiusBottomLeft", _radiusBottomLeft, 0);
            state.SetPropertyValue("radiusBottomRight", _radiusBottomRight, 0);
            state.SetPropertyValue("radiusTopLeft", _radiusTopLeft, 0);
            state.SetPropertyValue("radiusTopRight", _radiusTopRight, 0);
            state.SetPropertyValue("inset", _inset, false);
            state.SetPropertyValue("shadowBlurRadius", _shadowBlurRadius, 0);
            state.SetPropertyValue("shadowColor", _shadowColor, null);
            state.SetPropertyValue("shadowHorizontalLength", _shadowHorizontalLength, 0);
            state.SetPropertyValue("shadowSpreadRadius", _shadowSpreadRadius, 0);
            state.SetPropertyValue("shadowVerticalLength", _shadowVerticalLength, 0);
            state.SetPropertyValue("innerColorBottom", _innerColorBottom, null);
            state.SetPropertyValue("innerColorLeft", _innerColorLeft, null);
            state.SetPropertyValue("innerColorRight", _innerColorRight, null);
            state.SetPropertyValue("innerColorTop", _innerColorTop, null);
            state.SetPropertyValue("innerOpacity", _innerOpacity, 1);
            state.SetPropertyValue("innerWidthBottom", _innerWidthBottom, 0);
            state.SetPropertyValue("innerWidthLeft", _innerWidthLeft, 0);
            state.SetPropertyValue("innerWidthRight", _innerWidthRight, 0);
            state.SetPropertyValue("innerWidthTop", _innerWidthTop, 0);
            state.SetPropertyValue("colorPositionUnit", _colorPositionUnit, ColorPositionUnitEnum.percent);
            state.SetPropertyValue("endColor", _endColor, null);
            state.SetPropertyValue("endColorPosition", _endColorPosition, 100);
            state.SetPropertyValue("orientation", _orientation, OrientationEnum.vertical);
            state.SetPropertyValue("startColor", _startColor, null);
            state.SetPropertyValue("startColorPosition", _startColorPosition, 0);
            state.SetPropertyValue("borderImage", _borderImage, "");
            state.SetPropertyValue("borderImageMode", _borderImageMode, BorderImageModeEnum.grid);
            state.SetPropertyValue("fill", _fill, true);
            state.SetPropertyValue("repeatX", _repeatX, RepeatEnum.stretch);
            state.SetPropertyValue("repeatY", _repeatY, RepeatEnum.stretch);
            state.SetPropertyValue("sliceBottom", _sliceBottom, 0);
            state.SetPropertyValue("sliceLeft", _sliceLeft, 0);
            state.SetPropertyValue("sliceRight", _sliceRight, 0);
            state.SetPropertyValue("sliceTop", _sliceTop, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
