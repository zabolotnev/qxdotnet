using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A form virtual widget which allows a single selection. Looks somewhat like
    /// a normal button, but opens a virtual list of items to select when tapping
    /// on it.
    /// 
    /// </summary>
    public partial class VirtualSelectBox : qxDotNet.UI.Form.Core.AbstractVirtualBox
    {

        private qxDotNet.Data.Array _selection = null;


        /// <summary>
        /// Current selected items.
        /// 
        /// </summary>
        public qxDotNet.Data.Array Selection
        {
            get
            {
                return _selection;
            }
            set
            {
               _selection = value;
               OnChangeSelection();
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.VirtualSelectBox";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selection", _selection, null);


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
        /// Fired on change of the property {@link #selection}.
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
