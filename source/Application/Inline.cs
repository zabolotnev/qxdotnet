using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// For a GUI application on a traditional, HTML-dominated web page.  The ideal environment for typical portal sites which use just a few qooxdoo widgets. {@link qx.ui.root.Inline} can be used to embed qooxdoo widgets into the page flow.
    /// </summary>
    public partial class Inline : qxDotNet.Application.AbstractGui
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.application.Inline";
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
