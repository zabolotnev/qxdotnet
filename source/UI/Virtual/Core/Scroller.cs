using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Core
{
    /// <summary>
    /// EXPERIMENTAL!  The Scroller wraps a {@link Pane} and provides scroll bars to interactively scroll the pane&#8217;s content.
    /// </summary>
    public partial class Scroller : qxDotNet.UI.Core.Scroll.AbstractScrollArea
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.core.Scroller";
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
