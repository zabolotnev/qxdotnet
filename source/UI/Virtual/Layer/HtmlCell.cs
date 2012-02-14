using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  The HtmlCell layer renders each cell with custom HTML markup. The concrete markup for each cell is provided by a cell provider.
    /// </summary>
    public partial class HtmlCell : qxDotNet.UI.Virtual.Layer.Abstract
    {




        public override string GetTypeName()
        {
            return "qx.ui.virtual.layer.HtmlCell";
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
