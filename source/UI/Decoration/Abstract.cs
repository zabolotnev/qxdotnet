using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// This class acts as abstract class for all decorators. It offers the properties for the insets handling. Every decorator has to define its own default insets by implementing the template method (http://en.wikipedia.org/wiki/Template_Method) _getDefaultInsets . Another template method called _isInitialized should return weather the decorator is initialized of not.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object, qxDotNet.UI.Decoration.IDecorator
    {

        private decimal _insetBottom = 0m;
        private decimal _insetLeft = 0m;
        private decimal _insetRight = 0m;
        private decimal _insetTop = 0m;


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
            return "qx.ui.decoration.Abstract";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
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
