using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Celleditor
{
    /// <summary>
    /// A cell editor factory which can dynamically exchange the cell editor
    /// based on information retrieved at runtime. This is useful when different
    /// rows in a column should have different cellEditors based on cell content
    /// or row meta data. A typical example would be a spreadsheet that has different
    /// kind of data in one column.
    /// 
    /// </summary>
    public partial class Dynamic : qxDotNet.Core.Object, qxDotNet.UI.Table.ICellEditorFactory
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.celleditor.Dynamic";
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
