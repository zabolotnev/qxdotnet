﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Container
{
    /// <summary>
    /// The stack container puts its child widgets on top of each other and only the
    /// topmost widget is visible.
    /// 
    /// This is used e.g. in the tab view widget. Which widget is visible can be
    /// controlled by using the {@link #getSelection} method.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    ///  // create stack container
    ///  var stack = new qx.ui.container.Stack();
    /// 
    ///  // add some children
    ///  stack.add(new qx.ui.core.Widget().set({
    ///  backgroundColor: "red"
    ///  }));
    ///  stack.add(new qx.ui.core.Widget().set({
    ///  backgroundColor: "green"
    ///  }));
    ///  stack.add(new qx.ui.core.Widget().set({
    ///  backgroundColor: "blue"
    ///  }));
    /// 
    ///  // select green widget
    ///  stack.setSelection([stack.getChildren()[1]]);
    /// 
    ///  this.getRoot().add(stack);
    /// 
    /// 
    /// This example creates an stack with three children. Only the selected "green"
    /// widget is visible.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Stack : qxDotNet.UI.Core.ChildrenHandling, qxDotNet.UI.Core.ISingleSelection
    {

        private bool? _dynamic = false;
        private qxDotNet.UI.Core.Widget _selection = null;


        /// <summary>
        /// Whether the size of the widget depends on the selected child. When
        /// disabled (default) the size is configured to the largest child.
        /// 
        /// </summary>
        public bool? Dynamic
        {
            get
            {
                return _dynamic;
            }
            set
            {
               _dynamic = value;
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.container.Stack";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("dynamic", _dynamic, false);
            state.SetPropertyValue("selection", _selection, null);

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
        /// Fires after the selection was modified
        /// 
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
