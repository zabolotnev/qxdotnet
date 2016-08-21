using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// A simple tree data model used as the table model
    /// 
    /// The object structure of a single node of the tree is:
    /// 
    /// 
    /// {
    ///  // USER-PROVIDED ATTRIBUTES
    ///  // ------------------------
    ///  type : qx.ui.treevirtual.MTreePrimitive.Type.LEAF,
    ///  parentNodeId : 23, // index of the parent node in _nodeArr
    /// 
    ///  label : "My Documents",
    ///  bSelected : true, // true if node is selected; false otherwise.
    ///  bOpened : true, // true (-), false (+)
    ///  bHideOpenClose : false, // whether to hide the open/close button
    ///  icon : "images/folder.gif",
    ///  iconSelected : "images/folder_selected.gif",
    /// 
    ///  cellStyle : "background-color:cyan"
    ///  labelStyle : "background-color:red;color:white"
    /// 
    ///  // USER-PROVIDED COLUMN DATA
    ///  columnData : [
    ///  null, // null at index of tree column (typically 0)
    ///  "text of column 1",
    ///  "text of column 2"
    ///  ],
    /// 
    ///  // APPLICATION-, MIXIN-, and SUBCLASS-PROVIDED CUSTOM DATA
    ///  data : {
    ///  application :
    ///  {
    ///  // application-specific user data goes in here
    ///  foo: "bar",
    ///  ...
    ///  },
    ///  MDragAndDropSupport :
    ///  {
    ///  // Data required for the Drag & Drop mixin.
    ///  // When a mixin is included, its constructor
    ///  // should create this object, named according
    ///  // to the mixin or subclass name (empty or
    ///  // otherwise)
    ///  },
    ///  ... // Additional mixins or subclasses.
    ///  },
    /// 
    ///  // INTERNALLY-CALCULATED ATTRIBUTES
    ///  // --------------------------------
    ///  // The following properties need not (and should not) be set by the
    ///  // caller, but are automatically calculated. Some are used internally,
    ///  // while others may be of use to event listeners.
    /// 
    ///  nodeId : 42, // The index in _nodeArr, useful to event listeners.
    ///  children : [ ], // each value is an index into _nodeArr
    /// 
    ///  level : 2, // The indentation level of this tree node
    /// 
    ///  bFirstChild : true,
    ///  lastChild : [ false ], // Array where the index is the column of
    ///  // indentation, and the value is a boolean.
    ///  // These are used to locate the
    ///  // appropriate "tree line" icon.
    /// }
    /// 
    /// </summary>
    internal partial class SimpleTreeDataModel : qxDotNet.UI.Table.Model.Abstract
    {

//TODO: private _array _data = null;
        private qxDotNet.UI.Treevirtual.TreeVirtual _tree = null;
        private int _treeColumn = 0;


        /// <summary>
        /// Get the tree object for which this data model is used.
        /// 
        /// Set the tree object for which this data model is used.
        /// 
        /// </summary>
        public qxDotNet.UI.Treevirtual.TreeVirtual Tree
        {
            get
            {
                return _tree;
            }
            set
            {
               _tree = value;
            }
        }

        /// <summary>
        /// Get the column in which the tree is to be displayed.
        /// 
        /// Specifies which column the tree is to be displayed in. The tree is
        /// displayed using the SimpleTreeDataCellRenderer. Other columns may be
        /// provided which use different cell renderers.
        /// 
        /// Setting the tree column involves more than simply setting this column
        /// index; it also requires setting an appropriate cell renderer for this
        /// column, that knows how to render a tree. The expected and typical
        /// method of setting the tree column is to provide it in the 'custom'
        /// parameter to the TreeVirtual constructor, which also initializes the
        /// proper cell renderers. This method does not set any cell renderers. If
        /// you wish to call this method on your own, you should also manually set
        /// the cell renderer for the specified column, and likely also set the
        /// cell renderer for column 0 (the former tree column) to something
        /// appropriate to your data.
        /// 
        /// </summary>
        public int TreeColumn
        {
            get
            {
                return _treeColumn;
            }
            set
            {
               _treeColumn = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.treevirtual.SimpleTreeDataModel";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("tree", _tree, null);
            state.SetPropertyValue("treeColumn", _treeColumn, 0);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
