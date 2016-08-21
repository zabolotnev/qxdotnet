using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Celleditor
{
    /// <summary>
    /// For editing boolean data in a checkbox. It is advisable to use this in
    /// conjunction with {@link qx.ui.table.cellrenderer.Boolean}.
    /// 
    /// </summary>
    public partial class CheckBox : qxDotNet.Core.Object, qxDotNet.UI.Table.ICellEditorFactory
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.celleditor.CheckBox";
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
