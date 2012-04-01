using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// The VBox decorator uses three images, which are rendered in a column.  The first and last image always keep their original size. The center image is stretched vertically.  This decorator can be used for widgets with a fixed width, which can be stretched vertically.
    /// </summary>
    public partial class VBox : qxDotNet.UI.Decoration.AbstractBox
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.decoration.VBox";
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
