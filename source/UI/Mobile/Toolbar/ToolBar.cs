using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Toolbar
{
    /// <summary>
    /// A toolbar widget.
    /// </summary>
    public partial class ToolBar : qxDotNet.UI.Mobile.Container.Composite
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.toolbar.ToolBar";
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
