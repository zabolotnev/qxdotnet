using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// The default data cell renderer.
    /// </summary>
    public partial class Default : qxDotNet.UI.Table.Cellrenderer.Abstract
    {

        private bool? _useAutoAlign = true;


        /// <summary>
        /// Whether the alignment should automatically be set according to the cell value. If true numbers will be right-aligned.
        /// </summary>
        public bool? UseAutoAlign
        {
            get
            {
                return _useAutoAlign;
            }
            set
            {
               _useAutoAlign = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Default";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("useAutoAlign", _useAutoAlign, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
