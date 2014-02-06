using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Media
{
    /// <summary>
    /// EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION  Media object for playing videos.
    /// </summary>
    public partial class Video : qxDotNet.Bom.Media.Abstract
    {

        private decimal _height = 0m;
        private string _poster = "";
        private decimal _width = 0m;


        /// <summary>
        /// 
        /// </summary>
        public decimal Height
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
        public string Poster
        {
            get
            {
                return _poster;
            }
            set
            {
               _poster = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Width
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
            return "qx.bom.media.Video";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("height", _height, 0m);
            state.SetPropertyValue("poster", _poster, "");
            state.SetPropertyValue("width", _width, 0m);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
