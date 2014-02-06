using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Rowrenderer
{
    /// <summary>
    /// The default data row renderer.
    /// </summary>
    public partial class Default : qxDotNet.Core.Object, qxDotNet.UI.Table.IRowRenderer
    {

        private bool? _highlightFocusRow = true;


        /// <summary>
        /// Whether the focused row should be highlighted.
        /// </summary>
        public bool? HighlightFocusRow
        {
            get
            {
                return _highlightFocusRow;
            }
            set
            {
               _highlightFocusRow = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.table.rowrenderer.Default";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("highlightFocusRow", _highlightFocusRow, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
