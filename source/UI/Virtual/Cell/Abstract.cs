using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// Abstract base class for HTML based cell renderer.  HTML cell renderer are used to construct an HTML string, which is used to render the cell.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object, qxDotNet.UI.Virtual.Cell.ICell
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.Abstract";
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
