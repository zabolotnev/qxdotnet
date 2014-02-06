using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// Managed wrapper for the HTML canvas tag.
    /// </summary>
    public partial class Canvas : qxDotNet.Html.Element
    {

        private int _height = 0;
        private int _width = 0;


        /// <summary>
        /// 
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
               _height = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
               _width = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.html.Canvas";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("height", _height, 0);
            state.SetPropertyValue("width", _width, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
