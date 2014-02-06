using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// Date cell renderer.  Renders a date according to the configured date formatter.  EXPERIMENTAL!
    /// </summary>
    public partial class Date : qxDotNet.UI.Virtual.Cell.Cell
    {

        private qxDotNet.Util.Format.DateFormat _dateFormat = null;


        /// <summary>
        /// The date format used to render the cell
        /// </summary>
        public qxDotNet.Util.Format.DateFormat DateFormat
        {
            get
            {
                return _dateFormat;
            }
            set
            {
               _dateFormat = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.Date";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("dateFormat", _dateFormat, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
