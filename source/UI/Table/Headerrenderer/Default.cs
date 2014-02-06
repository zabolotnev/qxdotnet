using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Headerrenderer
{
    /// <summary>
    /// The default header cell renderer.
    /// </summary>
    public partial class Default : qxDotNet.Core.Object, qxDotNet.UI.Table.IHeaderRenderer
    {

        private string _toolTip = null;


        /// <summary>
        /// ToolTip to show if the mouse hovers of the icon
        /// </summary>
        public string ToolTip
        {
            get
            {
                return _toolTip;
            }
            set
            {
               _toolTip = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.table.headerrenderer.Default";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("toolTip", _toolTip, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
