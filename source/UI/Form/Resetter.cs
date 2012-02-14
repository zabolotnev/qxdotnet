using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The resetter is responsible for managing a set of items and resetting these items on a {@link #reset} call. It can handle all form items supplying a value property and all widgets implementing the single selection linked list or select box.
    /// </summary>
    public partial class Resetter : qxDotNet.Core.Object
    {




        public override string GetTypeName()
        {
            return "qx.ui.form.Resetter";
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
