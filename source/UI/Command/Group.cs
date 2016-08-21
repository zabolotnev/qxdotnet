using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Command
{
    /// <summary>
    /// Registrar for commands to be able to group them.
    /// 
    /// </summary>
    public partial class Group : qxDotNet.Core.Object
    {

        private bool? _active = true;


        /// <summary>
        /// Activates or deactivates all commands in group.
        /// 
        /// </summary>
        public bool? Active
        {
            get
            {
                return _active;
            }
            set
            {
               _active = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.command.Group";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("active", _active, true);


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
