using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Toolbar
{
    /// <summary>
    /// A separator widget used to separate widgets in a toolbar.
    /// </summary>
    public partial class Separator : qxDotNet.UI.Mobile.Core.Widget
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.toolbar.Separator";
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
