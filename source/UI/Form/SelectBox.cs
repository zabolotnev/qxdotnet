using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A form widget which allows a single selection. Looks somewhat like
    /// a normal button, but opens a list of items to select when tapping on it.
    /// 
    /// Keep in mind that the SelectBox widget has always a selected item (due to the
    /// single selection mode). Right after adding the first item a changeSelection
    /// event is fired.
    /// 
    /// 
    /// var selectBox = new qx.ui.form.SelectBox();
    /// 
    /// selectBox.addListener("changeSelection", function(e) {
    ///  // ...
    /// });
    /// 
    /// // now the 'changeSelection' event is fired
    /// selectBox.add(new qx.ui.form.ListItem("Item 1"));
    /// 
    /// </summary>
    public partial class SelectBox : qxDotNet.UI.Form.AbstractSelectBox, qxDotNet.UI.Core.ISingleSelection, qxDotNet.UI.Form.IModelSelection
    {

        private qxDotNet.UI.Core.Widget _selection = null;
        private qxDotNet.Data.Array _modelSelection = null;


        /// <summary>
        /// Returns an array of currently selected items.
        /// 
        /// Note: The result is only a set of selected items, so the order can
        /// differ from the sequence in which the items were added.
        /// 
        /// Replaces current selection with the given items.
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
        /// Returns always an array of the models of the selected items. If no
        /// item is selected or no model is given, the array will be empty.
        /// 
        /// CAREFUL! The model selection can only work if every item item in the
        /// selection providing widget has a model property!
        /// 
        /// Takes the given models in the array and searches for the corresponding
        /// selectables. If an selectable does have that model attached, it will be
        /// selected.
        /// 
        /// Attention: This method can have a time complexity of O(n^2)!
        /// 
        /// CAREFUL! The model selection can only work if every item item in the
        /// selection providing widget has a model property!
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.SelectBox";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selection", _selection, null);
            state.SetPropertyValue("modelSelection", _modelSelection, null);

            state.SetEvent("changeSelection", true, "selection");

            if (ChangeModelSelection != null)
            {
                state.SetEvent("changeModelSelection", false);
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
            if (eventName == "changeModelSelection")
            {
                OnChangeModelSelection();
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
        /// Fires after the selection was modified
        /// 
        /// </summary>
        public event EventHandler ChangeSelection;

        /// <summary>
        /// Raises event 'ChangeModelSelection'
        /// </summary>
        protected virtual void OnChangeModelSelection()
        {
            if (ChangeModelSelection != null)
            {
                ChangeModelSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Pseudo event. It will never be fired because the array itself can not
        /// be changed. But the event description is needed for the data binding.
        /// 
        /// </summary>
        public event EventHandler ChangeModelSelection;

    }
}
