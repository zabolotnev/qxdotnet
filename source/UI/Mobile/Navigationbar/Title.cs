using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Navigationbar
{
    /// <summary>
    /// A navigation bar title widget.
    /// </summary>
    public partial class Title : qxDotNet.UI.Mobile.Basic.Label
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.navigationbar.Title";
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
