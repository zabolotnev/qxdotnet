using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Selection
{
    /// <summary>
    /// EXPERIMENTAL!  Row selection manager
    /// </summary>
    public partial class Row : qxDotNet.UI.Virtual.Selection.Abstract
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.selection.Row";
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
