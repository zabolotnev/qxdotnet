using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  Abstract base class for the {@link Row} and {@link Column} layers.
    /// </summary>
    public partial class AbstractBackground : qxDotNet.UI.Virtual.Layer.Abstract
    {

        private string _colorEven = null;
        private string _colorOdd = null;
        private string _background = "";
        private string _color = null;


        /// <summary>
        /// color for event indexes
        /// </summary>
        public string ColorEven
        {
            get
            {
                return _colorEven;
            }
            set
            {
               _colorEven = value;
            }
        }

        /// <summary>
        /// color for odd indexes
        /// </summary>
        public string ColorOdd
        {
            get
            {
                return _colorOdd;
            }
            set
            {
               _colorOdd = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Background
        {
            get
            {
                return _background;
            }
            set
            {
               _background = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
               _color = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.layer.AbstractBackground";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("colorEven", _colorEven, null);
            state.SetPropertyValue("colorOdd", _colorOdd, null);
            state.SetPropertyValue("background", _background, "");
            state.SetPropertyValue("color", _color, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
