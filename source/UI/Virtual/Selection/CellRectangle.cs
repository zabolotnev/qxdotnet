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
    public partial class CellRectangle : qxDotNet.UI.Virtual.Selection.Abstract
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.selection.CellRectangle";
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
