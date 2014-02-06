using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// Number cell renderer.  Renders the call using the configured number formatter.  EXPERIMENTAL!
    /// </summary>
    public partial class Number : qxDotNet.UI.Virtual.Cell.Cell
    {

        private qxDotNet.Util.Format.NumberFormat _numberFormat = null;


        /// <summary>
        /// The number format used to render the cell
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


        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.Number";
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
