using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Pane
{
    /// <summary>
    /// Clipping area for the table header and table pane.
    /// </summary>
    public partial class Clipper : qxDotNet.UI.Container.Composite
    {




        public override string GetTypeName()
        {
            return "qx.ui.table.pane.Clipper";
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
