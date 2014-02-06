using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// The PasswordField is a single-line password input field.
    /// </summary>
    public partial class PasswordField : qxDotNet.UI.Mobile.Form.TextField
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.PasswordField";
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
