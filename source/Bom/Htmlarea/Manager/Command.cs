using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom.Htmlarea.Manager
{
    /// <summary>
    /// Available commands for the HtmlArea component
    /// </summary>
    public partial class Command : qxDotNet.Core.Object
    {




        protected internal override string GetTypeName()
        {
            return "qx.bom.htmlarea.manager.Command";
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
