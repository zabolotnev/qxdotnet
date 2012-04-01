using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Layer
{
    /// <summary>
    /// EXPERIMENTAL!  The WidgetCell layer renders each cell with a qooxdoo widget. The concrete widget instance for each cell is provided by a cell provider.
    /// </summary>
    public partial class WidgetCell : qxDotNet.UI.Virtual.Layer.Abstract
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.layer.WidgetCell";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (Updated != null)
            {
                state.SetEvent("updated", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "updated")
            {
                OnUpdated();
            }
        }

        protected virtual void OnUpdated()
        {
            if (Updated != null)
            {
                Updated.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Is fired when the {@link #_fullUpdate} or the {@link #_updateLayerWindow} is finished.
        /// </summary>
        public event EventHandler Updated;

    }
}
