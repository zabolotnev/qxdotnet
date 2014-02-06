using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Navigationbar
{
    /// <summary>
    /// A navigation bar widget.  Example  Here is a little example of how to use the widget.    var bar = new qx.ui.mobile.navigationbar.NavigationBar();  var backButton = new qx.ui.mobile.navigationbar.BackButton();  bar.add(backButton);  var title = new qx.ui.mobile.navigationbar.Title();  var.add(title, {flex:1});   this.getRoot.add(bar);   This example creates a navigation bar and adds a back button and a title to it.
    /// </summary>
    public partial class NavigationBar : qxDotNet.UI.Mobile.Container.Composite
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.navigationbar.NavigationBar";
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
