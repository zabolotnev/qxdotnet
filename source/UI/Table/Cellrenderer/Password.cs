using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// A cell renderer which hides cell values such as passwords form view by masking them by *s
    /// </summary>
    public partial class Password : qxDotNet.UI.Table.Cellrenderer.Default
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Password";
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
