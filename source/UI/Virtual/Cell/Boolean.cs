using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// EXPERIMENTAL!
    /// </summary>
    public partial class Boolean : qxDotNet.UI.Virtual.Cell.AbstractImage
    {

        private string _iconFalse = "";
        private string _iconTrue = "";


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


        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.Boolean";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("iconFalse", _iconFalse, "");
            state.SetPropertyValue("iconTrue", _iconTrue, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
