using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.List.Renderer
{
    /// <summary>
    /// The default list item renderer. Used as the default renderer by the {@link qx.ui.mobile.list.provider.Provider}. Configure the renderer by setting the {@link qx.ui.mobile.list.List#delegate} property.  Example  Here is a little example of how to use the widget.     // Create the list with a delegate that  // configures the list item.  var list = new qx.ui.mobile.list.List({  configureItem : function(item, data, row)  {  item.setImage(\path/to/image.png\);  item.setTitle(data.title);  item.setSubtitle(data.subtitle);  }  });   This example creates a list with a delegate that configures the list item with the given data.
    /// </summary>
    public partial class Default : qxDotNet.UI.Mobile.List.Renderer.Abstract
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.list.renderer.Default";
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
