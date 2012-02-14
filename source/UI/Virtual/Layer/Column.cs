using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  The Row layer renders row background colors.
    /// </summary>
    public partial class Column : qxDotNet.UI.Virtual.Layer.AbstractBackground
    {




        public override string GetTypeName()
        {
            return "qx.ui.virtual.layer.Column";
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
