using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// This is the root element for a set of {@link qx.html.Element}s.  To make other elements visible these elements must be inserted into an root element at any level.  A root element uses an existing DOM element where is assumed that this element is always visible. In the easiest case, the root element is identical to the document's body.
    /// </summary>
    public partial class Root : qxDotNet.Html.Element
    {




        protected internal override string GetTypeName()
        {
            return "qx.html.Root";
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
