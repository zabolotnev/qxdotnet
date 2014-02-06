using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Layout
{
    /// <summary>
    /// Base class for all layout managers.  Custom layout managers must derive from this class and implement the methods {@link #_getCssClasses}, {@link #_getSupportedChildLayoutProperties} and {@link #_setLayoutProperty}.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.layout.Abstract";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (UpdateLayout != null)
            {
                state.SetEvent("updateLayout", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "updateLayout")
            {
                OnUpdateLayout();
            }
        }

        protected virtual void OnUpdateLayout()
        {
            if (UpdateLayout != null)
            {
                UpdateLayout.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the layout is updated. Data contains the "widget", "action", "properties"
        /// </summary>
        public event EventHandler UpdateLayout;

    }
}
