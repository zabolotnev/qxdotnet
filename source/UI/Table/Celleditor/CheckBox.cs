using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Celleditor
{
    /// <summary>
    /// For editing boolean data in a checkbox. It is advisable to use this in conjunction with {@link qx.ui.table.cellrenderer.Boolean}.
    /// </summary>
    public partial class CheckBox : qxDotNet.Core.Object, qxDotNet.UI.Table.ICellEditorFactory
    {



        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.celleditor.CheckBox";
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
