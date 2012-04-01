using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  Abstract base class for layers of a virtual pane.  This class queues calls to {@link #fullUpdate}, {@link #updateLayerWindow} and {@link #updateLayerData} and only performs the absolute necessary actions. Concrete implementation of this class must at least implement the {@link #_fullUpdate} method. Additionally the two methods {@link #_updateLayerWindow} and {@link #_updateLayerData} may be implemented to increase the performance.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.UI.Core.Widget, qxDotNet.UI.Virtual.Core.ILayer
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.layer.Abstract";
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
