using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// A list of items. Displays an automatically scrolling list for all
    /// added {@link qx.ui.form.ListItem} instances. Supports various
    /// selection options: single, multi, ...
    /// 
    /// </summary>
    public partial class List : qxDotNet.UI.Core.Scroll.AbstractScrollArea, qxDotNet.UI.Core.IMultiSelection, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IModelSelection
    {

        private bool? _enableInlineFind = true;
        private qxDotNet.OrientationEnum _orientation = OrientationEnum.vertical;
        private int _spacing = 0;
        private bool? _dragSelection = false;
        private bool? _quickSelection = false;
        private qxDotNet.SelectionModeEnum _selectionMode = SelectionModeEnum.single;
        private qxDotNet.UI.Core.Widget _selection = null;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;
        private qxDotNet.Data.Array _modelSelection = null;


        /// <summary>
        /// Controls whether the inline-find feature is activated or not
        /// 
        /// </summary>
        public bool? EnableInlineFind
        {
            get
            {
                return _enableInlineFind;
            }
            set
            {
               _enableInlineFind = value;
            }
        }

        /// <summary>
        /// Whether the list should be rendered horizontal or vertical.
        /// 
        /// </summary>
        public qxDotNet.OrientationEnum Orientation
        {
            get
            {
                return _orientation;
            }
            set
            {
               _orientation = value;
            }
        }

        /// <summary>
        /// Spacing between the items
        /// 
        /// </summary>
        public int Spacing
        {
            get
            {
                return _spacing;
            }
            set
            {
               _spacing = value;
            }
        }

        /// <summary>
        /// Enable drag selection (multi selection of items through
        /// dragging the pointer in pressed states).
        /// 
        /// Only possible for the selection modes multi and additive
        /// 
        /// </summary>
        public bool? DragSelection
        {
            get
            {
                return _dragSelection;
            }
            set
            {
               _dragSelection = value;
            }
        }

        /// <summary>
        /// Enable quick selection mode, where no tap is needed to change the selection.
        /// 
        /// Only possible for the modes single and one.
        /// 
        /// </summary>
        public bool? QuickSelection
        {
            get
            {
                return _quickSelection;
            }
            set
            {
               _quickSelection = value;
            }
        }

        /// <summary>
        /// The selection mode to use.
        /// 
        /// For further details please have a look at:
        /// {@link qx.ui.core.selection.Abstract#mode}
        /// 
        /// </summary>
        public qxDotNet.SelectionModeEnum SelectionMode
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
        /// Message which is shown in an invalid tooltip.
        /// 
        /// </summary>
        public string InvalidMessage
        {
            get
            {
                return _invalidMessage;
            }
            set
            {
               _invalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is required.
        /// 
        /// </summary>
        public bool? Required
        {
            get
            {
                return _required;
            }
            set
            {
               _required = value;
               OnChangeRequired();
            }
        }

        /// <summary>
        /// Message which is shown in an invalid tooltip if the {@link #required} is
        /// set to true.
        /// 
        /// </summary>
        public string RequiredInvalidMessage
        {
            get
            {
                return _requiredInvalidMessage;
            }
            set
            {
               _requiredInvalidMessage = value;
               OnChangeInvalidMessage();
            }
        }

        /// <summary>
        /// Flag signaling if a widget is valid. If a widget is invalid, an invalid
        /// state will be set.
        /// 
        /// </summary>
        public bool? Valid
        {
            get
            {
                return _valid;
            }
            set
            {
               _valid = value;
               OnChangeValid();
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
            return "qx.ui.form.List";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("enableInlineFind", _enableInlineFind, true);
            state.SetPropertyValue("orientation", _orientation, OrientationEnum.vertical);
            state.SetPropertyValue("spacing", _spacing, 0);
            state.SetPropertyValue("dragSelection", _dragSelection, false);
            state.SetPropertyValue("quickSelection", _quickSelection, false);
            state.SetPropertyValue("selectionMode", _selectionMode, SelectionModeEnum.single);
            state.SetPropertyValue("selection", _selection, null);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);
            state.SetPropertyValue("modelSelection", _modelSelection, null);

            if (AddItem != null)
            {
                state.SetEvent("addItem", false);
            }
            if (RemoveItem != null)
            {
                state.SetEvent("removeItem", false);
            }
            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false);
            }
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
            if (eventName == "addItem")
            {
                OnAddItem();
            }
            if (eventName == "removeItem")
            {
                OnRemoveItem();
            }
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
        /// Raises event 'AddItem'
        /// </summary>
        protected virtual void OnAddItem()
        {
            if (AddItem != null)
            {
                AddItem.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after a list item was added to the list. The
        /// {@link qx.event.type.Data#getData} method of the event returns the
        /// added item.
        /// 
        /// </summary>
        public event EventHandler AddItem;

        /// <summary>
        /// Raises event 'RemoveItem'
        /// </summary>
        protected virtual void OnRemoveItem()
        {
            if (RemoveItem != null)
            {
                RemoveItem.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after a list item has been removed from the list.
        /// The {@link qx.event.type.Data#getData} method of the event returns the
        /// removed item.
        /// 
        /// </summary>
        public event EventHandler RemoveItem;

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
        /// Raises event 'ChangeInvalidMessage'
        /// </summary>
        protected virtual void OnChangeInvalidMessage()
        {
            if (ChangeInvalidMessage != null)
            {
                ChangeInvalidMessage.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #invalidMessage}.
        /// </summary>
        public event EventHandler ChangeInvalidMessage;

        /// <summary>
        /// Raises event 'ChangeRequired'
        /// </summary>
        protected virtual void OnChangeRequired()
        {
            if (ChangeRequired != null)
            {
                ChangeRequired.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #required}.
        /// </summary>
        public event EventHandler ChangeRequired;

        /// <summary>
        /// Raises event 'ChangeValid'
        /// </summary>
        protected virtual void OnChangeValid()
        {
            if (ChangeValid != null)
            {
                ChangeValid.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #valid}.
        /// </summary>
        public event EventHandler ChangeValid;

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
