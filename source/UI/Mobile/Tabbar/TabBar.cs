using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Tabbar
{
    /// <summary>
    /// This widget displays a tab bar.  Example  Here is a little example of how to use the widget.    var tabBar = new qx.ui.mobile.tabbar.TabBar();  var tabButton1 = new qx.ui.mobile.tabbar.TabButton(\Tab1\);  tabButton1.setView(view1);  tabBar.add(tabButton1);  var tabButton2 = new qx.ui.mobile.tabbar.TabButton(\Tab2\);  tabButton2.setView(view2);  tabBar.add(tabButton2);   this.getRoot.add(tabBar);   This example creates a tab bar and adds two tab buttons to it.
    /// </summary>
    public partial class TabBar : qxDotNet.UI.Mobile.Core.Widget
    {

        private qxDotNet.UI.Mobile.Tabbar.TabButton _selection = null;


        /// <summary>
        /// Sets the selected tab.
        /// </summary>
        public qxDotNet.UI.Mobile.Tabbar.TabButton Selection
        {
            get
            {
                return _selection;
            }
            set
            {
               _selection = value;
               OnChangeSelection();
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.tabbar.TabBar";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selection", _selection, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #selection}.
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
