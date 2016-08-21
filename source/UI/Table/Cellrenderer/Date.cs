using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// Specific data cell renderer for dates.
    /// 
    /// </summary>
    public partial class Date : qxDotNet.UI.Table.Cellrenderer.Conditional
    {

        private qxDotNet.Util.Format.DateFormat _dateFormat = null;


        /// <summary>
        /// DateFormat used to format the data.
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Date";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("dateFormat", _dateFormat, null);


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
