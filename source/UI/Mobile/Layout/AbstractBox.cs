using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Layout
{
    /// <summary>
    /// Base class for all box layout managers.
    /// </summary>
    public abstract partial class AbstractBox : qxDotNet.UI.Mobile.Layout.Abstract
    {

        private qxDotNet.AlignXEnum _alignX = (AlignXEnum)(-1);
        private qxDotNet.AlignYEnum _alignY = (AlignYEnum)(-1);
        private bool? _reversed = null;


        /// <summary>
        /// Horizontal alignment of the whole children block.
        /// </summary>
        public qxDotNet.AlignXEnum AlignX
        {
            get
            {
                return _alignX;
            }
            set
            {
               _alignX = value;
            }
        }

        /// <summary>
        /// Vertical alignment of each child.
        /// </summary>
        public qxDotNet.AlignYEnum AlignY
        {
            get
            {
                return _alignY;
            }
            set
            {
               _alignY = value;
            }
        }

        /// <summary>
        /// Children will be displayed in reverse order.
        /// </summary>
        public bool? Reversed
        {
            get
            {
                return _reversed;
            }
            set
            {
               _reversed = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.layout.AbstractBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("alignX", _alignX, (AlignXEnum)(-1));
            state.SetPropertyValue("alignY", _alignY, (AlignYEnum)(-1));
            state.SetPropertyValue("reversed", _reversed, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
