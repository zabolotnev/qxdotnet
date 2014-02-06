using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Core
{
    /// <summary>
    /// EXPERIMENTAL!  A cell event instance contains all data for mouse events related to cells in a pane.
    /// </summary>
    public partial class CellEvent : qxDotNet.Event.Type.Mouse
    {

        private int _column = 0;
        private int _row = 0;


        /// <summary>
        /// The table column of the event target.
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
        /// The table row of the event target.
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


        public override string GetTypeName()
        {
            return "qx.ui.virtual.core.CellEvent";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("column", _column, 0);
            state.SetPropertyValue("row", _row, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
