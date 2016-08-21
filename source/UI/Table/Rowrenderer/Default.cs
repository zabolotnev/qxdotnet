using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Rowrenderer
{
    /// <summary>
    /// The default data row renderer.
    /// 
    /// </summary>
    public partial class Default : qxDotNet.Core.Object, qxDotNet.UI.Table.IRowRenderer
    {

        private bool? _highlightFocusRow = true;


        /// <summary>
        /// Whether the focused row should be highlighted.
        /// 
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.rowrenderer.Default";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("highlightFocusRow", _highlightFocusRow, true);


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
