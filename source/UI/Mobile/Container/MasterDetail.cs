using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// The master/detail container divides an area into two panes, master and detail. The master can be detached when the orientation of the device changes to portrait. This container provides an optimized view for tablet and mobile devices.  Example  Here is a little example of how to use the master/detail container.   var container = new qx.ui.mobile.container.MasterDetail();  container.getMaster().add(new qx.ui.mobile.container.Navigation()); container.getDetail().add(new qx.ui.mobile.container.Navigation());  
    /// </summary>
    public partial class MasterDetail : qxDotNet.UI.Mobile.Container.Composite
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.MasterDetail";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (LayoutChange != null)
            {
                state.SetEvent("layoutChange", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "layoutChange")
            {
                OnLayoutChange();
            }
        }

        protected virtual void OnLayoutChange()
        {
            if (LayoutChange != null)
            {
                LayoutChange.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the layout of the master detail is changed. This happens when the orientation of the device is changed.
        /// </summary>
        public event EventHandler LayoutChange;

    }
}
