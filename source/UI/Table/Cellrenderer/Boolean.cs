using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Cellrenderer
{
    /// <summary>
    /// A data cell renderer for boolean values.
    /// </summary>
    public partial class Boolean : qxDotNet.UI.Table.Cellrenderer.AbstractImage
    {

        private string _iconFalse = "decoration/table/boolean-false.png";
        private string _iconTrue = "decoration/table/boolean-true.png";


        /// <summary>
        /// The icon used to indicate the false state
        /// </summary>
        public string IconFalse
        {
            get
            {
                return _iconFalse;
            }
            set
            {
               _iconFalse = value;
            }
        }

        /// <summary>
        /// The icon used to indicate the true state
        /// </summary>
        public string IconTrue
        {
            get
            {
                return _iconTrue;
            }
            set
            {
               _iconTrue = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.cellrenderer.Boolean";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("iconFalse", _iconFalse, "decoration/table/boolean-false.png");
            state.SetPropertyValue("iconTrue", _iconTrue, "decoration/table/boolean-true.png");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
