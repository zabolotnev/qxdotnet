using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  An extended WidgetCell layer, which adds the possibility to specify row and column spans for specific cells.
    /// </summary>
    public partial class WidgetCellSpan : qxDotNet.UI.Virtual.Layer.Abstract
    {




        public override string GetTypeName()
        {
            return "qx.ui.virtual.layer.WidgetCellSpan";
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
