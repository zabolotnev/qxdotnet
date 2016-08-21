using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Menu
{
    /// <summary>
    /// This widget draws a separator line between two instances of
    /// {@link qx.ui.menu.AbstractButton} and is inserted into the
    /// {@link qx.ui.menu.Menu}.
    /// 
    /// For convenience reasons there is also
    /// a method {@link qx.ui.menu.Menu#addSeparator} to append instances
    /// of this class to the menu.
    /// 
    /// </summary>
    public partial class Separator : qxDotNet.UI.Core.Widget
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.menu.Separator";
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
