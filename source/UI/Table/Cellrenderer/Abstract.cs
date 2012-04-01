using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// An abstract data cell renderer that does the basic coloring (borders, selected look, ...).
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object, qxDotNet.UI.Table.ICellRenderer
    {

        private string _defaultCellStyle = null;


        /// <summary>
        /// The default cell style. The value of this property will be provided to the cell renderer as cellInfo.style.
        /// </summary>
        public string DefaultCellStyle
        {
            get
            {
                return _defaultCellStyle;
            }
            set
            {
               _defaultCellStyle = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Abstract";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("defaultCellStyle", _defaultCellStyle, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
