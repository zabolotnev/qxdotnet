using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// Abstract base class for widget based cell renderer.
    /// </summary>
    public partial class AbstractWidget : qxDotNet.Core.Object, qxDotNet.UI.Virtual.Cell.IWidgetCell
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.AbstractWidget";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            state.SetEvent("created", false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "created")
            {
                OnCreated();
            }
        }

        protected virtual void OnCreated()
        {
            if (Created != null)
            {
                Created.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a new LayoutItem is created.
        /// </summary>
        public event EventHandler Created;

    }
}
