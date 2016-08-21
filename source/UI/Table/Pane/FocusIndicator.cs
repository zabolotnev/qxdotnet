using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Pane
{
    /// <summary>
    /// The focus indicator widget
    /// 
    /// </summary>
    public partial class FocusIndicator : qxDotNet.UI.Container.Composite
    {

        private int _column = 0;
        private int _row = 0;


        /// <summary>
        /// Table column, where the indicator is placed.
        /// 
        /// </summary>
        public int Column
        {
            get
            {
                return _column;
            }
            set
            {
               _column = value;
            }
        }

        /// <summary>
        /// Table row, where the indicator is placed.
        /// 
        /// </summary>
        public int Row
        {
            get
            {
                return _row;
            }
            set
            {
               _row = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.pane.FocusIndicator";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("column", _column, 0);
            state.SetPropertyValue("row", _row, 0);


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
