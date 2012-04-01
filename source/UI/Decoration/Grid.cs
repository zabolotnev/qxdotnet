using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// A very complex decoration using two, partly combined and clipped images to render a graphically impressive borders with gradients.  The decoration supports all forms of vertical gradients. The gradients must be stretchable to support different heights.  The edges could use different styles of rounded borders. Even different edge sizes are supported. The sizes are automatically detected by the build system using the image meta data.  The decoration uses clipped images to reduce the number of external resources to load.
    /// </summary>
    public partial class Grid : qxDotNet.Core.Object, qxDotNet.UI.Decoration.IDecorator
    {

        private string _baseImage = "";
        private decimal _insetBottom = 0m;
        private decimal _insetLeft = 0m;
        private decimal _insetRight = 0m;
        private decimal _insetTop = 0m;


        /// <summary>
        /// Base image URL. There must be an image with this name and the sliced and the nine sliced images. The sliced images must be named according to the following scheme:  ${baseImageWithoutExtension}-${imageName}.${baseImageExtension}  These image names are used:   tl (top-left edge) t (top side) tr (top-right edge)    bl (bottom-left edge) b (bottom side) br (bottom-right edge)    l (left side) c (center image) r (right side) 
        /// </summary>
        public string BaseImage
        {
            get
            {
                return _baseImage;
            }
            set
            {
               _baseImage = value;
            }
        }

        /// <summary>
        /// Width of the bottom inset (keep this margin to the outer box)
        /// </summary>
        public decimal InsetBottom
        {
            get
            {
                return _insetBottom;
            }
            set
            {
               _insetBottom = value;
            }
        }

        /// <summary>
        /// Width of the left inset (keep this margin to the outer box)
        /// </summary>
        public decimal InsetLeft
        {
            get
            {
                return _insetLeft;
            }
            set
            {
               _insetLeft = value;
            }
        }

        /// <summary>
        /// Width of the right inset (keep this margin to the outer box)
        /// </summary>
        public decimal InsetRight
        {
            get
            {
                return _insetRight;
            }
            set
            {
               _insetRight = value;
            }
        }

        /// <summary>
        /// Width of the top inset (keep this margin to the outer box)
        /// </summary>
        public decimal InsetTop
        {
            get
            {
                return _insetTop;
            }
            set
            {
               _insetTop = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.Grid";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("baseImage", _baseImage, "");
            state.SetPropertyValue("insetBottom", _insetBottom, 0m);
            state.SetPropertyValue("insetLeft", _insetLeft, 0m);
            state.SetPropertyValue("insetRight", _insetRight, 0m);
            state.SetPropertyValue("insetTop", _insetTop, 0m);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
