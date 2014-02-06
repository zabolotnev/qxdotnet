using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// Abstract base class for image cell renderer.  EXPERIMENTAL!
    /// </summary>
    public abstract partial class AbstractImage : qxDotNet.UI.Virtual.Cell.Cell
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.AbstractImage";
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
