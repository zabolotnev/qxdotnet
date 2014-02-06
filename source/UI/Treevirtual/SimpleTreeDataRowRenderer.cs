using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// A data row renderer for a simple tree row
    /// </summary>
    public partial class SimpleTreeDataRowRenderer : qxDotNet.UI.Table.Rowrenderer.Default
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.treevirtual.SimpleTreeDataRowRenderer";
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
