using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Columnmodel.Resizebehavior
{
    /// <summary>
    /// An abstract resize behavior. All resize behaviors should extend this class.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.table.columnmodel.resizebehavior.Abstract";
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
