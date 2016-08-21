using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{
    /// <summary>
    /// A Spacer is a "virtual" widget, which can be placed into any layout and takes
    /// the space a normal widget of the same size would take.
    /// 
    /// Spacers are invisible and very light weight because they don't require any
    /// DOM modifications.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    ///  var container = new qx.ui.container.Composite(new qx.ui.layout.HBox());
    ///  container.add(new qx.ui.core.Widget());
    ///  container.add(new qx.ui.core.Spacer(50));
    ///  container.add(new qx.ui.core.Widget());
    /// 
    /// 
    /// This example places two widgets and a spacer into a container with a
    /// horizontal box layout. In this scenario the spacer creates an empty area of
    /// 50 pixel width between the two widgets.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Spacer : qxDotNet.UI.Core.LayoutItem
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.Spacer";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
