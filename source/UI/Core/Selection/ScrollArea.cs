using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core.Selection
{
    /// <summary>
    /// A selection manager, which handles the selection in widgets extending {@link qx.ui.core.scroll.AbstractScrollArea}.
    /// </summary>
    public partial class ScrollArea : qxDotNet.UI.Core.Selection.Widget
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.selection.ScrollArea";
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
