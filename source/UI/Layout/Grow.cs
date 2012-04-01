using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// The grow layout stretches all children to the full available size but still respects limits configured by min/max values.  It will place all children over each other with the top and left coordinates set to 0. The {@link qx.ui.container.Stack} and the {@link qx.ui.core.scroll.ScrollPane} are using this layout.  Features   Auto-sizing Respects minimum and maximum child dimensions   Item Properties  None  Example   var layout = new qx.ui.layout.Grow();  var w1 = new qx.ui.core.Widget(); var w2 = new qx.ui.core.Widget(); var w3 = new qx.ui.core.Widget();  var container = new qx.ui.container.Composite(layout); container.add(w1); container.add(w2); container.add(w3);   External Documentation   Extended documentation and links to demos of this layout in the qooxdoo manual.
    /// </summary>
    public partial class Grow : qxDotNet.UI.Layout.Abstract
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Grow";
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
