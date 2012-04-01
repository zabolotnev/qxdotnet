using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  An extended HtmlCell layer, which adds the possibility to specify row and column spans for specific cells.
    /// </summary>
    public partial class HtmlCellSpan : qxDotNet.UI.Virtual.Layer.HtmlCell
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.layer.HtmlCellSpan";
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
