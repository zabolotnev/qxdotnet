using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Selection
{
    /// <summary>
    /// EXPERIMENTAL!  Abstract base class for selection manager, which manage selectable items rendered in a virtual {@link qx.ui.virtual.core.Pane}.
    /// </summary>
    public partial class Abstract : qxDotNet.UI.Core.Selection.Abstract
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.selection.Abstract";
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
