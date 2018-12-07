using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Selection
{
    /// <summary>
    /// A selection model.
    /// 
    /// </summary>
    public partial class Model : qxDotNet.Core.Object
    {

        private int _selectionMode = 2;


        /// <summary>
        /// Set the selection mode. Valid values are {@link #NO_SELECTION},
        /// {@link #SINGLE_SELECTION}, {@link #SINGLE_INTERVAL_SELECTION},
        /// {@link #MULTIPLE_INTERVAL_SELECTION} and
        /// {@link #MULTIPLE_INTERVAL_SELECTION_TOGGLE}.
        /// 
        /// </summary>
        public int SelectionMode
        {
            get
            {
                return _selectionMode;
            }
            set
            {
               _selectionMode = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.selection.Model";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selectionMode", _selectionMode, 2);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false, "selectedRanges");
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeSelection")
            {
                OnChangeSelection();
            }
        }

        /// <summary>
        /// Raises event 'ChangeSelection'
        /// </summary>
        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the selection has changed.
        /// 
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
