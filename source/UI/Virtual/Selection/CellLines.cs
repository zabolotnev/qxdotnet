using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Selection
{
    /// <summary>
    /// EXPERIMENTAL!  Cell selection manager
    /// </summary>
    public partial class CellLines : qxDotNet.UI.Virtual.Selection.CellRectangle
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.selection.CellLines";
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
