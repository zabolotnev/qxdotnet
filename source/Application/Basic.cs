using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// For a basic, out-of-browser application (running e.g. on Node.js, Rhino).
    /// </summary>
    public partial class Basic : qxDotNet.Core.Object, qxDotNet.Application.IApplication
    {




        public override string GetTypeName()
        {
            return "qx.application.Basic";
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
