using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The TextField is a single-line text input field.
    /// </summary>
    public partial class TextField : qxDotNet.UI.Form.AbstractField
    {




        public override string GetTypeName()
        {
            return "qx.ui.form.TextField";
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
