using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Headerrenderer
{
    /// <summary>
    /// The default header cell renderer.
    /// 
    /// </summary>
    public partial class Default : qxDotNet.Core.Object, qxDotNet.UI.Table.IHeaderRenderer
    {

        private string _toolTip = null;


        /// <summary>
        /// ToolTip to show if the pointer hovers of the icon
        /// 
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.headerrenderer.Default";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("toolTip", _toolTip, null);


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
