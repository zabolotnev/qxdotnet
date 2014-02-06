using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// The default data cell renderer for a virtual tree (columns other than the tree column)
    /// </summary>
    public partial class DefaultDataCellRenderer : qxDotNet.UI.Table.Cellrenderer.Default
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.treevirtual.DefaultDataCellRenderer";
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
