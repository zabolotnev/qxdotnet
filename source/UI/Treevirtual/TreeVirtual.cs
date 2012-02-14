using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// A &#8220;virtual&#8221; tree  A number of convenience methods are available in the following mixins:    {@link qx.ui.treevirtual.MNode}  {@link qx.ui.treevirtual.MFamily}  
    /// </summary>
    public partial class TreeVirtual : qxDotNet.UI.Table.Table
    {

        private bool? _openCloseClickSelectsRow = false;
        private bool? _alwaysShowOpenCloseSymbol = false;
        private bool? _excludeFirstLevelTreeLines = false;
        private int _selectionMode = 0;
        private bool? _useTreeLines = false;


        /// <summary>
        /// Whether a click on the open/close button should also cause selection of the row.
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


        public override string GetTypeName()
        {
            return "qx.ui.treevirtual.TreeVirtual";
        }

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

        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the selected rows change.  Event data: An array of node objects (the selected rows&#8217; nodes) from the data model. Each node object is described in {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// </summary>
        public event EventHandler ChangeSelection;

        protected virtual void OnTreeClose()
        {
            if (TreeClose != null)
            {
                TreeClose.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a tree branch is closed.  Event data: the node object from the data model (of the node being closed) as described in {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// </summary>
        public event EventHandler TreeClose;

        protected virtual void OnTreeOpenWhileEmpty()
        {
            if (TreeOpenWhileEmpty != null)
            {
                TreeOpenWhileEmpty.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when an empty tree branch is opened.  Event data: the node object from the data model (of the node being opened) as described in {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// </summary>
        public event EventHandler TreeOpenWhileEmpty;

        protected virtual void OnTreeOpenWithContent()
        {
            if (TreeOpenWithContent != null)
            {
                TreeOpenWithContent.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a tree branch which already has content is opened.  Event data: the node object from the data model (of the node being opened) as described in {@link qx.ui.treevirtual.SimpleTreeDataModel}
        /// </summary>
        public event EventHandler TreeOpenWithContent;

    }
}
