using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// The normal toolbar button. Like a normal {@link qx.ui.form.Button} but with a style matching the toolbar and without keyboard support.
    /// </summary>
    public partial class Button : qxDotNet.UI.Form.Button
    {




        public override string GetTypeName()
        {
            return "qx.ui.toolbar.Button";
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
