using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// A selection manager. This is a helper class that handles all selection
    /// related events and updates a SelectionModel.
    /// 
    /// This Selection Manager differs from its superclass in that we do not want
    /// rows to be selected when moving around with the keyboard.
    /// 
    /// </summary>
    public partial class SelectionManager : qxDotNet.UI.Table.Selection.Manager
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.treevirtual.SelectionManager";
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
