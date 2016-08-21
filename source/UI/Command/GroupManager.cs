using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Command
{
    /// <summary>
    /// Registrar for command groups to be able to active or deactive them.
    /// 
    /// </summary>
    public partial class GroupManager : qxDotNet.Core.Object
    {

        private qxDotNet.UI.Command.Group _active = null;


        /// <summary>
        /// Returns active command group.
        /// 
        /// Activates a command group and deactivates all other added groups.
        /// 
        /// </summary>
        public qxDotNet.UI.Command.Group Active
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
            return "qx.ui.command.GroupManager";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("active", _active, null);


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
