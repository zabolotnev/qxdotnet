using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// Specific data cell renderer for dates.
    /// </summary>
    public partial class Date : qxDotNet.UI.Table.Cellrenderer.Conditional
    {

        private qxDotNet.Util.Format.DateFormat _dateFormat = null;


        /// <summary>
        /// DateFormat used to format the data.
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

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Date";
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
