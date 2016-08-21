using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Columnmodel
{
    /// <summary>
    /// A table column model that automatically resizes columns based on a
    /// selected behavior.
    /// 
    /// </summary>
    public partial class Resize : qxDotNet.UI.Table.Columnmodel.Basic
    {

        private qxDotNet.UI.Table.Columnmodel.Resizebehavior.Abstract _behavior = null;


        /// <summary>
        /// The behavior to use.
        /// 
        /// The provided behavior must extend {@link qx.ui.table.columnmodel.resizebehavior.Abstract} and
        /// implement the onAppear, onTableWidthChanged,
        /// onColumnWidthChanged and onVisibilityChangedmethods.
        /// 
        /// </summary>
        public qxDotNet.UI.Table.Columnmodel.Resizebehavior.Abstract Behavior
        {
            get
            {
                return _behavior;
            }
            set
            {
               _behavior = value;
               OnChangeBehavior();
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.columnmodel.Resize";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("behavior", _behavior, null);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        /// <summary>
        /// Raises event 'ChangeBehavior'
        /// </summary>
        protected virtual void OnChangeBehavior()
        {
            if (ChangeBehavior != null)
            {
                ChangeBehavior.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #behavior}.
        /// </summary>
        public event EventHandler ChangeBehavior;

    }
}
