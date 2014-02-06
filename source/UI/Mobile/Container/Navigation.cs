using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Container
{
    /// <summary>
    /// The navigation controller includes already a {@link qx.ui.mobile.navigationbar.NavigationBar} and a {@link qx.ui.mobile.container.Composite} container with a {@link qx.ui.mobile.layout.Card} layout. All widgets that implement the {@link qx.ui.mobile.container.INavigation} interface can be added to the container. The added widget provide the title widget and the left/right container, which will be automatically merged into navigation bar.  Example  Here is a little example of how to use the widget.    var container = new qx.ui.mobile.container.Navigation();  this.getRoot(container);  var page = new qx.ui.mobile.page.NavigationPage();  container.add(page);  page.show(); 
    /// </summary>
    public partial class Navigation : qxDotNet.UI.Mobile.Container.Composite
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.container.Navigation";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (Update != null)
            {
                state.SetEvent("update", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "update")
            {
                OnUpdate();
            }
        }

        protected virtual void OnUpdate()
        {
            if (Update != null)
            {
                Update.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the navigation bar gets updated
        /// </summary>
        public event EventHandler Update;

    }
}
