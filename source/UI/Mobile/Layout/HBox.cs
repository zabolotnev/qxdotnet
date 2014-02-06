using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Layout
{
    /// <summary>
    /// A horizontal box layout.  The horizontal box layout lays out widgets in a horizontal row, from left to right.  Item Properties   flex (Integer): The flex property determines how the container  distributes remaining empty space among its children. If items are made  flexible, they can grow or shrink accordingly. Their relative flex values  determine how the items are being resized, i.e. the larger the flex ratio  of two items, the larger the resizing of the first item compared to the  second.    Example  Here is a little example of how to use the HBox layout.   var layout = new qx.ui.mobile.layout.HBox().set({alignX:\center\});  var container = new qx.ui.mobile.container.Composite(layout);  container.add(new qx.ui.mobile.basic.Label(\1\)); container.add(new qx.ui.mobile.basic.Label(\2\), {flex:1}); container.add(new qx.ui.mobile.basic.Label(\3\)); 
    /// </summary>
    public partial class HBox : qxDotNet.UI.Mobile.Layout.AbstractBox
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.layout.HBox";
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
