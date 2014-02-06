using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// This Cellrender is for transparent use, without escaping! Use this Cellrender to output plain HTML content.
    /// </summary>
    public partial class Html : qxDotNet.UI.Table.Cellrenderer.Conditional
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Html";
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
