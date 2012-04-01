using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Celleditor
{
    /// <summary>
    /// A cell editor factory creating select boxes.
    /// </summary>
    public partial class SelectBox : qxDotNet.Core.Object, qxDotNet.UI.Table.ICellEditorFactory
    {

//        private _array _listData = null;


        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.celleditor.SelectBox";
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
