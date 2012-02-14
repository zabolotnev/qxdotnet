using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// For a Non-GUI application, supporting low-level DOM operations and AJAX communication.
    /// </summary>
    public partial class Native : qxDotNet.Core.Object, qxDotNet.Application.IApplication
    {




        public override string GetTypeName()
        {
            return "qx.application.Native";
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
