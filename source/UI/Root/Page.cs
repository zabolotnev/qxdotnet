using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Root
{
    /// <summary>
    /// This widget provides a root widget for popups and tooltips if qooxdoo is used inside a traditional HTML page. Widgets placed into a page will overlay the HTML content.  For this reason the widget";s layout is initialized with an instance of {@link qx.ui.layout.Basic}. The widget";s layout cannot be changed.  The page widget does not support paddings and decorators with insets.  Note: This widget does not support decorations!  If you want to place widgets inside existing DOM elements use {@link qx.ui.root.Inline}.
    /// </summary>
    public partial class Page : qxDotNet.UI.Root.Abstract
    {




        protected internal override string GetTypeName()
        {
            return "qx.ui.root.Page";
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
