using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// A template class for cell renderer, which display images. Concrete implementations must implement the method {@link #_identifyImage}.
    /// </summary>
    public abstract partial class AbstractImage : qxDotNet.UI.Table.Cellrenderer.Abstract
    {

//        private _var _repeat = "no-repeat";



        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.AbstractImage";
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
