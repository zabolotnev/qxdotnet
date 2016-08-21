using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core.Selection
{
    /// <summary>
    /// Generic selection manager to bring rich desktop like selection behavior
    /// to widgets and low-level interactive controls.
    /// 
    /// The selection handling supports both Shift and Ctrl/Meta modifies like
    /// known from native applications.
    /// 
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object
    {

        private bool? _drag = false;
        private qxDotNet.ModeEnum _mode = ModeEnum.single;
        private bool? _quick = false;


        /// <summary>
        /// Enable drag selection (multi selection of items through
        /// dragging the pointer in pressed states).
        /// 
        /// Only possible for the modes multi and additive
        /// 
        /// </summary>
        public bool? Drag
        {
            get
            {
                return _drag;
            }
            set
            {
               _drag = value;
            }
        }

        /// <summary>
        /// Selects the selection mode to use.
        /// 
        /// 
        /// single: One or no element is selected
        /// multi: Multi items could be selected. Also allows empty selections.
        /// additive: Easy Web-2.0 selection mode. Allows multiple selections without modifier keys.
        /// one: If possible always exactly one item is selected
        /// 
        /// </summary>
        public qxDotNet.ModeEnum Mode
        {
            get
            {
                return _mode;
            }
            set
            {
               _mode = value;
            }
        }

        /// <summary>
        /// Enable quick selection mode, where no tap is needed to change the selection.
        /// 
        /// Only possible for the modes single and one.
        /// 
        /// </summary>
        public bool? Quick
        {
            get
            {
                return _quick;
            }
            set
            {
               _quick = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.selection.Abstract";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("drag", _drag, false);
            state.SetPropertyValue("mode", _mode, ModeEnum.single);
            state.SetPropertyValue("quick", _quick, false);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false);
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
        /// Fires after the selection was modified. Contains the selection under the data property.
        /// 
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
