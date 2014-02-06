using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Core
{
    /// <summary>
    /// Connects the widgets to the browser DOM events.
    /// </summary>
    public partial class EventHandler : qxDotNet.Core.Object, qxDotNet.Event.IEventHandler
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.core.EventHandler";
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
