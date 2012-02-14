using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A form virtual widget which allows a single selection. Looks somewhat like a normal button, but opens a virtual list of items to select when clicking on it.
    /// </summary>
    public partial class VirtualSelectBox : qxDotNet.UI.Form.Core.AbstractVirtualBox
    {

        private qxDotNet.Data.Array _selection = null;


        /// <summary>
        /// Current selected items.
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


        public override string GetTypeName()
        {
            return "qx.ui.form.VirtualSelectBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selection", _selection, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

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
