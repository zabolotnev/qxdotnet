using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tree
{
    /// <summary>
    /// The Tree class implements a tree widget, with collapsible and expandable container nodes and terminal leaf nodes. You instantiate a Tree object and then assign the tree a root folder using the {@link #root} property.  If you don&#8217;t want to show the root item, you can hide it with the {@link #hideRoot} property.  The handling of selections within a tree is somewhat distributed between the root tree object and the attached {@link qx.ui.tree.selection.SelectionManager}. To get the currently selected element of a tree use the tree {@link #getSelection} method and tree {@link #setSelection} to set it. The TreeSelectionManager handles more coarse-grained issues like providing {@link #selectAll} and {@link #resetSelection} methods.
    /// </summary>
    public partial class Tree : qxDotNet.UI.Core.Scroll.AbstractScrollArea, qxDotNet.UI.Core.IMultiSelection, qxDotNet.UI.Form.IModelSelection, qxDotNet.UI.Form.IForm
    {

        private bool? _hideRoot = false;
        private qxDotNet.OpenModeEnum _openMode = OpenModeEnum.dblclick;
        private qxDotNet.UI.Tree.Core.AbstractTreeItem _root = null;
        private bool? _rootOpenClose = false;
        private bool? _dragSelection = false;
        private bool? _quickSelection = false;
        private qxDotNet.SelectionModeEnum _selectionMode = SelectionModeEnum.single;
        private qxDotNet.UI.Core.Widget _selection = null;
        private int _contentPaddingBottom = 0;
        private int _contentPaddingLeft = 0;
        private int _contentPaddingRight = 0;
        private int _contentPaddingTop = 0;
        private qxDotNet.Data.Array _modelSelection = null;
        private string _invalidMessage = "";
        private bool? _required = false;
        private string _requiredInvalidMessage = "";
        private bool? _valid = true;


        /// <summary>
        /// Hide the root (Tree) node. This differs from the visibility property in that this property hides only the root node, not the node&#8217;s children.
        /// </summary>
        public bool? HideRoot
        {
            get
            {
                return _hideRoot;
            }
            set
            {
               _hideRoot = value;
            }
        }

        /// <summary>
        /// Control whether clicks or double clicks should open or close the clicked folder.
        /// </summary>
        public qxDotNet.OpenModeEnum OpenMode
        {
            get
            {
                return _openMode;
            }
            set
            {
               _openMode = value;
               OnChangeOpenMode();
            }
        }

        /// <summary>
        /// The root tree item of the tree to display
        /// </summary>
        public qxDotNet.UI.Tree.Core.AbstractTreeItem Root
        {
            get
            {
                return _root;
            }
            set
            {
               _root = value;
               OnChangeRoot();
            }
        }

        /// <summary>
        /// Whether the Root should have an open/close button. This may also be used in conjunction with the hideNode property to provide for virtual root nodes. In the latter case, be very sure that the virtual root nodes are expanded programatically, since there will be no open/close button for the user to open them.
        /// </summary>
        public bool? RootOpenClose
        {
            get
            {
                return _rootOpenClose;
            }
            set
            {
               _rootOpenClose = value;
            }
        }

        /// <summary>
        /// Enable drag selection (multi selection of items through dragging the mouse in pressed states).  Only possible for the selection modes multi and additive
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
        /// Enable quick selection mode, where no click is needed to change the selection.  Only possible for the modes single and one.
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
        /// The selection mode to use.  For further details please have a look at: {@link qx.ui.core.selection.Abstract#mode}
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
        /// Bottom padding of the content pane
        /// </summary>
        public int ContentPaddingBottom
        {
            get
            {
                return _contentPaddingBottom;
            }
            set
            {
               _contentPaddingBottom = value;
            }
        }

        /// <summary>
        /// Left padding of the content pane
        /// </summary>
        public int ContentPaddingLeft
        {
            get
            {
                return _contentPaddingLeft;
            }
            set
            {
               _contentPaddingLeft = value;
            }
        }

        /// <summary>
        /// Right padding of the content pane
        /// </summary>
        public int ContentPaddingRight
        {
            get
            {
                return _contentPaddingRight;
            }
            set
            {
               _contentPaddingRight = value;
            }
        }

        /// <summary>
        /// Top padding of the content pane
        /// </summary>
        public int ContentPaddingTop
        {
            get
            {
                return _contentPaddingTop;
            }
            set
            {
               _contentPaddingTop = value;
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
        /// Message which is shown in an invalid tooltip.
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
        /// Message which is shown in an invalid tooltip if the {@link #required} is set to true.
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
        /// Flag signaling if a widget is valid. If a widget is invalid, an invalid state will be set.
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


        public override string GetTypeName()
        {
            return "qx.ui.tree.Tree";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("hideRoot", _hideRoot, false);
            state.SetPropertyValue("openMode", _openMode, OpenModeEnum.dblclick);
            state.SetPropertyValue("root", _root, null);
            state.SetPropertyValue("rootOpenClose", _rootOpenClose, false);
            state.SetPropertyValue("dragSelection", _dragSelection, false);
            state.SetPropertyValue("quickSelection", _quickSelection, false);
            state.SetPropertyValue("selectionMode", _selectionMode, SelectionModeEnum.single);
            state.SetPropertyValue("selection", _selection, null);
            state.SetPropertyValue("contentPaddingBottom", _contentPaddingBottom, 0);
            state.SetPropertyValue("contentPaddingLeft", _contentPaddingLeft, 0);
            state.SetPropertyValue("contentPaddingRight", _contentPaddingRight, 0);
            state.SetPropertyValue("contentPaddingTop", _contentPaddingTop, 0);
            state.SetPropertyValue("modelSelection", _modelSelection, null);
            state.SetPropertyValue("invalidMessage", _invalidMessage, "");
            state.SetPropertyValue("required", _required, false);
            state.SetPropertyValue("requiredInvalidMessage", _requiredInvalidMessage, "");
            state.SetPropertyValue("valid", _valid, true);

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

        protected virtual void OnAddItem()
        {
            if (AddItem != null)
            {
                AddItem.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after a tree item was added to the tree. The {@link qx.event.type.Data#getData} method of the event returns the added item.
        /// </summary>
        public event EventHandler AddItem;

        protected virtual void OnChangeOpenMode()
        {
            if (ChangeOpenMode != null)
            {
                ChangeOpenMode.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #openMode}.
        /// </summary>
        public event EventHandler ChangeOpenMode;

        protected virtual void OnChangeRoot()
        {
            if (ChangeRoot != null)
            {
                ChangeRoot.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #root}.
        /// </summary>
        public event EventHandler ChangeRoot;

        protected virtual void OnRemoveItem()
        {
            if (RemoveItem != null)
            {
                RemoveItem.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired after a tree item has been removed from the tree. The {@link qx.event.type.Data#getData} method of the event returns the removed item.
        /// </summary>
        public event EventHandler RemoveItem;

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

    }
}
