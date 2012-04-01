using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// Border implementation with two CSS borders. Both borders can be styled independent of each other. This decorator is used to create 3D effects like inset, outset, ridge or groove.
    /// </summary>
    public partial class Double : qxDotNet.UI.Decoration.Abstract
    {

        private string _backgroundColor = null;
        private string _innerColorBottom = null;
        private string _innerColorLeft = null;
        private string _innerColorRight = null;
        private string _innerColorTop = null;
        private decimal _innerWidthBottom = 0m;
        private decimal _innerWidthLeft = 0m;
        private decimal _innerWidthRight = 0m;
        private decimal _innerWidthTop = 0m;


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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.Double";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("backgroundColor", _backgroundColor, null);
            state.SetPropertyValue("innerColorBottom", _innerColorBottom, null);
            state.SetPropertyValue("innerColorLeft", _innerColorLeft, null);
            state.SetPropertyValue("innerColorRight", _innerColorRight, null);
            state.SetPropertyValue("innerColorTop", _innerColorTop, null);
            state.SetPropertyValue("innerWidthBottom", _innerWidthBottom, 0m);
            state.SetPropertyValue("innerWidthLeft", _innerWidthLeft, 0m);
            state.SetPropertyValue("innerWidthRight", _innerWidthRight, 0m);
            state.SetPropertyValue("innerWidthTop", _innerWidthTop, 0m);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
