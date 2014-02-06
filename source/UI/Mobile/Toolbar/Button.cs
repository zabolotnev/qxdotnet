using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Toolbar
{
    /// <summary>
    /// A button used in toolbars.
    /// </summary>
    public partial class Button : qxDotNet.UI.Mobile.Form.Button
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.toolbar.Button";
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
