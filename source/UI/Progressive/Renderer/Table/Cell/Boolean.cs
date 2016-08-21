using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Progressive.Renderer.Table.Cell
{
    /// <summary>
    /// Table Cell Boolean Renderer.
    /// 
    /// </summary>
    public partial class Boolean : qxDotNet.UI.Progressive.Renderer.Table.Cell.Icon
    {

        private bool? _allowToggle = false;


        /// <summary>
        /// Whether to add code which will toggle the checkbox on/off. (There is
        /// not yet code here to generate an event when this occurs, so it's not
        /// yet very useful.)
        /// 
        /// </summary>
        public bool? AllowToggle
        {
            get
            {
                return _allowToggle;
            }
            set
            {
               _allowToggle = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.progressive.renderer.table.cell.Boolean";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("allowToggle", _allowToggle, false);


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
