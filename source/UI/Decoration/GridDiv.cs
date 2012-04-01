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
    public partial class GridDiv : qxDotNet.UI.Decoration.Abstract
    {

        private string _baseImage = "";


        /// <summary>
        /// Base image URL. All the different images needed are named by the default naming scheme:  ${baseImageWithoutExtension}-${imageName}.${baseImageExtension}  These image names are used:   tl (top-left edge) t (top side) tr (top-right edge)    bl (bottom-left edge) b (bottom side) br (bottom-right edge)    l (left side) c (center image) r (right side) 
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.GridDiv";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("baseImage", _baseImage, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
