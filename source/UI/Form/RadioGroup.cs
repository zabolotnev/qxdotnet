using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The radio group handles a collection of items from which only one item
    /// can be selected. Selection another item will deselect the previously selected
    /// item.
    /// 
    /// This class is e.g. used to create radio groups or {@link qx.ui.form.RadioButton}
    /// or {@link qx.ui.toolbar.RadioButton} instances.
    /// 
    /// We also offer a widget for the same purpose which uses this class. So if
    /// you like to act with a widget instead of a pure logic coupling of the
    /// widgets, take a look at the {@link qx.ui.form.RadioButtonGroup} widget.
    /// 
    /// </summary>
    public partial class RadioGroup : qxDotNet.Core.Object, qxDotNet.UI.Core.ISingleSelection, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IModelSelection
    {

        private bool? _allowEmptySelection = false;
        private bool? _enabled = true;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;
        private bool? _wrap = true;
        private qxDotNet.UI.Core.Widget _selection = null;
        private qxDotNet.Data.Array _modelSelection = null;


        /// <summary>
        /// If is set to true the selection could be empty,
        /// otherwise is always one RadioButton selected.
        /// 
        /// </summary>
        public bool? AllowEmptySelection
        {
            get
            {
                return _allowEmptySelection;
            }
            set
            {
               _allowEmptySelection = value;
            }
        }

        /// <summary>
        /// Whether the radio group is enabled
        /// 
        /// </summary>
        public bool? Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
               _enabled = value;
               OnChangeEnabled();
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
        /// Flag signaling if the group is required.
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
        /// Flag signaling if the group at all is valid. All children will have the
        /// same state.
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
        /// Whether the selection should wrap around. This means that the successor of
        /// the last item is the first item.
        /// 
        /// </summary>
        public bool? Wrap
        {
            get
            {
                return _wrap;
            }
            set
            {
               _wrap = value;
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
            return "qx.ui.form.RadioGroup";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("allowEmptySelection", _allowEmptySelection, false);
            state.SetPropertyValue("enabled", _enabled, true);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);
            state.SetPropertyValue("wrap", _wrap, true);
            state.SetPropertyValue("selection", _selection, null);
            state.SetPropertyValue("modelSelection", _modelSelection, null);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", true, "selection");
            }
            else
            {
                state.SetEvent("changeSelection", false, "selection");
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
        /// Raises event 'ChangeEnabled'
        /// </summary>
        protected virtual void OnChangeEnabled()
        {
            if (ChangeEnabled != null)
            {
                ChangeEnabled.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #enabled}.
        /// </summary>
        public event EventHandler ChangeEnabled;

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
