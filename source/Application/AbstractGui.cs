using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// Abstract base class for GUI applications using qooxdoo widgets.
    /// </summary>
    public abstract partial class AbstractGui : qxDotNet.Core.Object, qxDotNet.Application.IApplication
    {




        public override string GetTypeName()
        {
            return "qx.application.AbstractGui";
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
