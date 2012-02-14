using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// A widget used for decoration proposes to structure a toolbar. Each Separator renders a line between the buttons around.
    /// </summary>
    public partial class Separator : qxDotNet.UI.Core.Widget
    {




        public override string GetTypeName()
        {
            return "qx.ui.toolbar.Separator";
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
