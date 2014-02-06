using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// This is a simple image class using the low level image features of qooxdoo and wraps it for the qx.html layer.
    /// </summary>
    public partial class Image : qxDotNet.Html.Element
    {

        private bool? _scale = false;
        private string _source = "";


        /// <summary>
        /// 
        /// </summary>
        public bool? Scale
        {
            get
            {
                return _scale;
            }
            set
            {
               _scale = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Source
        {
            get
            {
                return _source;
            }
            set
            {
               _source = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.html.Image";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("scale", _scale, false);
            state.SetPropertyValue("source", _source, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
