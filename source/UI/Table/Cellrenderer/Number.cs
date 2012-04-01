using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// Specific data cell renderer for numbers.
    /// </summary>
    public partial class Number : qxDotNet.UI.Table.Cellrenderer.Conditional
    {

        private qxDotNet.Util.Format.NumberFormat _numberFormat = null;


        /// <summary>
        /// NumberFormat used to format data. If the numberFormat contains a prefix and/or postfix containing characters which needs to be escaped, those need to be given to the numberFormat in their escaped form because no escaping happens at the cellrenderer level.
        /// </summary>
        public qxDotNet.Util.Format.NumberFormat NumberFormat
        {
            get
            {
                return _numberFormat;
            }
            set
            {
               _numberFormat = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Number";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("numberFormat", _numberFormat, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
