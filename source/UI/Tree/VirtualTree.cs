using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tree
{
    /// <summary>
    /// Virtual tree implementation.  The virtual tree can be used to render node and leafs. Nodes and leafs are both items for a tree. The difference between a node and a leaf is that a node has child items, but a leaf not.  With the {@link qx.ui.tree.core.IVirtualTreeDelegate} interface it is possible to configure the tree's behavior (item renderer configuration, etc.).  Here's an example of how to use the widget:   //create the model data var nodes = []; for (var i = 0; i 
    /// </summary>
    public partial class VirtualTree : qxDotNet.UI.Virtual.Core.Scroller, qxDotNet.UI.Tree.Core.IVirtualTree
    {

        private string _childProperty = "";
//        private _var _delegate = null;
        private bool? _hideRoot = false;
//        private _var _iconOptions = null;
        private string _iconPath = "";
        private int _itemHeight = 25;
//        private _var _labelOptions = null;
        private string _labelPath = "";
        private qxDotNet.Core.Object _model = null;
        private qxDotNet.OpenModeEnum _openMode = OpenModeEnum.dblclick;
        private bool? _showLeafs = true;
        private bool? _showTopLevelOpenCloseIcons = false;
        private int _contentPaddingBottom = 0;
        private int _contentPaddingLeft = 0;
        private int _contentPaddingRight = 0;
        private int _contentPaddingTop = 0;


        /// <summary>
        /// The name of the property, where the children are stored in the model. Instead of the {@link #labelPath} must the child property a direct property form the model instance.
        /// </summary>
        public string ChildProperty
        {
            get
            {
                return _childProperty;
            }
            set
            {
               _childProperty = value;
            }
        }

        /// <summary>
        /// Hides only the root node, not the node's children when the property is set to true.
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
        /// The path to the property which holds the information that should be shown as an icon.
        /// </summary>
        public string IconPath
        {
            get
            {
                return _iconPath;
            }
            set
            {
               _iconPath = value;
            }
        }

        /// <summary>
        /// Default item height.
        /// </summary>
        public int ItemHeight
        {
            get
            {
                return _itemHeight;
            }
            set
            {
               _itemHeight = value;
            }
        }

        /// <summary>
        /// The name of the property, where the value for the tree folders label is stored in the model classes.
        /// </summary>
        public string LabelPath
        {
            get
            {
                return _labelPath;
            }
            set
            {
               _labelPath = value;
            }
        }

        /// <summary>
        /// The model containing the data (nodes and/or leafs) which should be shown in the tree.
        /// </summary>
        public qxDotNet.Core.Object Model
        {
            get
            {
                return _model;
            }
            set
            {
               _model = value;
               OnChangeModel();
            }
        }

        /// <summary>
        /// Control whether clicks or double clicks should open or close the clicked item.
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
        /// Configures the tree to show also the leafs. When the property is set to false only the nodes are shown.
        /// </summary>
        public bool? ShowLeafs
        {
            get
            {
                return _showLeafs;
            }
            set
            {
               _showLeafs = value;
            }
        }

        /// <summary>
        /// Whether top level items should have an open/close button. The top level item item is normally the root item, but when the root is hidden, the root children are the top level items.
        /// </summary>
        public bool? ShowTopLevelOpenCloseIcons
        {
            get
            {
                return _showTopLevelOpenCloseIcons;
            }
            set
            {
               _showTopLevelOpenCloseIcons = value;
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tree.VirtualTree";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("childProperty", _childProperty, "");
            state.SetPropertyValue("hideRoot", _hideRoot, false);
            state.SetPropertyValue("iconPath", _iconPath, "");
            state.SetPropertyValue("itemHeight", _itemHeight, 25);
            state.SetPropertyValue("labelPath", _labelPath, "");
            state.SetPropertyValue("model", _model, null);
            state.SetPropertyValue("openMode", _openMode, OpenModeEnum.dblclick);
            state.SetPropertyValue("showLeafs", _showLeafs, true);
            state.SetPropertyValue("showTopLevelOpenCloseIcons", _showTopLevelOpenCloseIcons, false);
            state.SetPropertyValue("contentPaddingBottom", _contentPaddingBottom, 0);
            state.SetPropertyValue("contentPaddingLeft", _contentPaddingLeft, 0);
            state.SetPropertyValue("contentPaddingRight", _contentPaddingRight, 0);
            state.SetPropertyValue("contentPaddingTop", _contentPaddingTop, 0);

            state.SetEvent("close", false);
            state.SetEvent("open", false);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "close")
            {
                OnClose();
            }
            if (eventName == "open")
            {
                OnOpen();
            }
        }

        protected virtual void OnChangeDelegate()
        {
            if (ChangeDelegate != null)
            {
                ChangeDelegate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #delegate}.
        /// </summary>
        public event EventHandler ChangeDelegate;

        protected virtual void OnChangeModel()
        {
            if (ChangeModel != null)
            {
                ChangeModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #model}.
        /// </summary>
        public event EventHandler ChangeModel;

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

        protected virtual void OnClose()
        {
            if (Close != null)
            {
                Close.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a node is closed.
        /// </summary>
        public event EventHandler Close;

        protected virtual void OnOpen()
        {
            if (Open != null)
            {
                Open.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a node is opened.
        /// </summary>
        public event EventHandler Open;

    }
}
