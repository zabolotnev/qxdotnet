using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Form
{
    /// <summary>
    /// Shows a title text for {@link Form} or {@link Group}.
    /// </summary>
    public partial class Title : qxDotNet.UI.Mobile.Basic.Label
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.form.Title";
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
