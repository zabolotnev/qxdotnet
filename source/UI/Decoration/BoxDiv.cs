using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// Abstract base class for the HBox and VBox decorators.  This decorator uses three images, which are positioned in a vertical/horizontal line. The first and last image always keep their original size. The center image is stretched.
    /// </summary>
    public partial class BoxDiv : qxDotNet.UI.Decoration.Abstract
    {

        private string _baseImage = "";


        /// <summary>
        /// Base image URL. All the different images needed are named by the default naming scheme:  ${baseImageWithoutExtension}-${imageName}.${baseImageExtension}  These image names are used:   t: top side (vertical orientation) b: bottom side (vertical orientation)    l: left side (horizontal orientation) r: right side (horizontal orientation)    c: center image 
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
            return "qx.ui.decoration.BoxDiv";
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
