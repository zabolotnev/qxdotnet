using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// The HBox decorator uses three images, which are rendered in a row.  The first and last image always keep their original size. The center image is stretched horizontally.  This decorator can be used for widgets with a fixed height, which can be stretched horizontally.
    /// </summary>
    public partial class HBox : qxDotNet.UI.Decoration.AbstractBox
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.HBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
