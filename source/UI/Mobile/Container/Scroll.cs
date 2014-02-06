using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// Container, which allows, depending on the set variant qx.mobile.nativescroll, vertical and horizontal scrolling if the contents is larger than the container.  Note that this class can only have one child widget. This container has a fixed layout, which cannot be changed.  Example  Here is a little example of how to use the widget.    // create the scroll widget  var scroll = new qx.ui.mobile.container.Scroll()   // add a children  scroll.add(new qx.ui.mobile.basic.Label(\Name:\));   this.getRoot().add(scroll);   This example creates a scroll container and adds a label to it.
    /// </summary>
    public partial class Scroll : qxDotNet.UI.Mobile.Container.Composite
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.Scroll";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (PageEnd != null)
            {
                state.SetEvent("pageEnd", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "pageEnd")
            {
                OnPageEnd();
            }
        }

        protected virtual void OnPageEnd()
        {
            if (PageEnd != null)
            {
                PageEnd.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the user scrolls to the end of scroll area.
        /// </summary>
        public event EventHandler PageEnd;

    }
}
