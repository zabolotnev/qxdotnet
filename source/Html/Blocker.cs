using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// The blocker element is used to block interaction with the application.  It is usually transparent or semi-transparent and blocks all events from the underlying elements.
    /// </summary>
    public partial class Blocker : qxDotNet.Html.Element
    {




        protected internal override string GetTypeName()
        {
            return "qx.html.Blocker";
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
