using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// Base class for all layout managers.  Custom layout manager must derive from this class and implement the methods {@link #invalidateLayoutCache}, {@link #renderLayout} and {@link #getSizeHint}.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Abstract";
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
