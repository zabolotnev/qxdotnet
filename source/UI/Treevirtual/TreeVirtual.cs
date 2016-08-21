using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// A "virtual" tree
    /// 
    /// A number of convenience methods are available in the following mixins:
    ///  
    ///  {@link qx.ui.treevirtual.MNode}
    ///  {@link qx.ui.treevirtual.MFamily}
    ///  
    /// 
    /// </summary>
    public partial class TreeVirtual : qxDotNet.UI.Table.Table
    {

        private bool? _openCloseClickSelectsRow = false;
        private bool? _alwaysShowOpenCloseSymbol = false;
        private bool? _excludeFirstLevelTreeLines = false;
        private int _selectionMode = 0;
        private bool? _useTreeLines = false;


        /// <summary>
        /// Whether a click on the open/close button should also cause selection of
        /// the row.
        /// 
        /// </summary>
        public bool? OpenCloseClickSelectsRow
        {
            get
            {
                return _openCloseClickSelectsRow;
            }
            set
            {
               _openCloseClickSelectsRow = value;
            }
        }

        /// <summary>
        /// Set whether the open/close button should be displayed on a branch,
        /// even if the branch has no children.
        /// 
        /// Set whether the open/close button should be displayed on a branch,
        /// even if the branch has no children.
        /// 
        /// </summary>
        public bool? AlwaysShowOpenCloseSymbol
        {
            get
            {
                return _alwaysShowOpenCloseSymbol;
            }
            set
            {
               _alwaysShowOpenCloseSymbol = value;
            }
        }

        /// <summary>
        /// Get whether drawing of first-level tree lines should be disabled even
        /// if drawing of tree lines is enabled.
        /// (See also {@link #getUseTreeLines})
        /// 
        /// Set whether drawing of first-level tree-node lines are disabled even
        /// if drawing of tree lines is enabled.
        /// 
        /// </summary>
        public bool? ExcludeFirstLevelTreeLines
        {
            get
            {
                return _excludeFirstLevelTreeLines;
            }
            set
            {
               _excludeFirstLevelTreeLines = value;
            }
        }

        /// <summary>
        /// Get the selection mode currently in use.
        /// 
        /// Set the selection mode.
        /// 
        /// </summary>
        public int SelectionMode
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
        /// Get whether lines linking tree children shall be drawn on the tree.
        /// 
        /// Set whether lines linking tree children shall be drawn on the tree.
        /// Note that not all themes support tree lines. As of the time of this
        /// writing, the Classic theme supports tree lines (and uses +/- icons
        /// which lend themselves to tree lines), while the Modern theme, which
        /// uses right-facing and downward-facing arrows instead of +/-, does not.
        /// 
        /// </summary>
        public bool? UseTreeLines
        {
            get
            {
                return _useTreeLines;
            }
            set
            {
               _useTreeLines = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.treevirtual.TreeVirtual";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("openCloseClickSelectsRow", _openCloseClickSelectsRow, false);
            state.SetPropertyValue("alwaysShowOpenCloseSymbol", _alwaysShowOpenCloseSymbol, false);
            state.SetPropertyValue("excludeFirstLevelTreeLines", _excludeFirstLevelTreeLines, false);
            state.SetPropertyValue("selectionMode", _selectionMode, 0);
            state.SetPropertyValue("useTreeLines", _useTreeLines, false);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false);
            }
            if (TreeClose != null)
            {
                state.SetEvent("treeClose", false);
            }
            if (TreeOpenWhileEmpty != null)
            {
                state.SetEvent("treeOpenWhileEmpty", false);
            }
            if (TreeOpenWithContent != null)
            {
                state.SetEvent("treeOpenWithContent", false);
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
            if (eventName == "treeClose")
            {
                OnTreeClose();
            }
            if (eventName == "treeOpenWhileEmpty")
            {
                OnTreeOpenWhileEmpty();
            }
            if (eventName == "treeOpenWithContent")
            {
                OnTreeOpenWithContent();
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
        /// Fired when the selected rows change.
        /// 
        /// Event data: An array of node objects (the selected rows' nodes)
        /// from the data model. Each node object is described in
        /// {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// 
        /// </summary>
        public event EventHandler ChangeSelection;

        /// <summary>
        /// Raises event 'TreeClose'
        /// </summary>
        protected virtual void OnTreeClose()
        {
            if (TreeClose != null)
            {
                TreeClose.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a tree branch is closed.
        /// 
        /// Event data: the node object from the data model (of the node
        /// being closed) as described in
        /// {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// 
        /// </summary>
        public event EventHandler TreeClose;

        /// <summary>
        /// Raises event 'TreeOpenWhileEmpty'
        /// </summary>
        protected virtual void OnTreeOpenWhileEmpty()
        {
            if (TreeOpenWhileEmpty != null)
            {
                TreeOpenWhileEmpty.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when an empty tree branch is opened.
        /// 
        /// Event data: the node object from the data model (of the node
        /// being opened) as described in
        /// {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// 
        /// </summary>
        public event EventHandler TreeOpenWhileEmpty;

        /// <summary>
        /// Raises event 'TreeOpenWithContent'
        /// </summary>
        protected virtual void OnTreeOpenWithContent()
        {
            if (TreeOpenWithContent != null)
            {
                TreeOpenWithContent.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a tree branch which already has content is opened.
        /// 
        /// Event data: the node object from the data model (of the node
        /// being opened) as described in
        /// {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// 
        /// </summary>
        public event EventHandler TreeOpenWithContent;

    }
}
