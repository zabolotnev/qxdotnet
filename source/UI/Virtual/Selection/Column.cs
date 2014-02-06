using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Selection
{
    /// <summary>
    /// EXPERIMENTAL!  Column selection manager
    /// </summary>
    public partial class Column : qxDotNet.UI.Virtual.Selection.Row
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.selection.Column";
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
