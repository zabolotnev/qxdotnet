using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A password input field, which hides the entered text.
    /// </summary>
    public partial class PasswordField : qxDotNet.UI.Form.TextField
    {




        public override string GetTypeName()
        {
            return "qx.ui.form.PasswordField";
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
