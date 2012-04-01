using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A form widget which allows a single selection. Looks somewhat like a normal button, but opens a list of items to select when clicking on it.
    /// </summary>
    public partial class SelectBox : qxDotNet.UI.Form.AbstractSelectBox, qxDotNet.UI.Core.ISingleSelection, qxDotNet.UI.Form.IModelSelection
    {

        private qxDotNet.UI.Core.Widget _selection = null;
        private qxDotNet.Data.Array _modelSelection = null;


        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.UI.Core.Widget Selection
        {
            get
            {
                return _selection;
            }
            set
            {
               _selection = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public qxDotNet.Data.Array ModelSelection
        {
            get
            {
                return _modelSelection;
            }
            set
            {
               _modelSelection = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.SelectBox";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selection", _selection, null);
            state.SetPropertyValue("modelSelection", _modelSelection, null);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false);
            }
            if (ChangeModelSelection != null)
            {
                state.SetEvent("changeModelSelection", false);
            }

            state.SetEvent("changeSelection", false, "selection");

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeSelection")
            {
                OnChangeSelection();
            }
            if (eventName == "changeModelSelection")
            {
                OnChangeModelSelection();
            }
        }

        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fires after the selection was modified
        /// </summary>
        public event EventHandler ChangeSelection;

        protected virtual void OnChangeModelSelection()
        {
            if (ChangeModelSelection != null)
            {
                ChangeModelSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Pseudo event. It will never be fired because the array itself can not be changed. But the event description is needed for the data binding.
        /// </summary>
        public event EventHandler ChangeModelSelection;

    }
}
