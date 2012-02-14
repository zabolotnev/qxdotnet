using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// A button which acts as a normal button and shows a menu on one of the sides to open something like a history list.
    /// </summary>
    public partial class SplitButton : qxDotNet.UI.Form.SplitButton
    {




        public override string GetTypeName()
        {
            return "qx.ui.toolbar.SplitButton";
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
