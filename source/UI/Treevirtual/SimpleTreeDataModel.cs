using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// A simple tree data model used as the table model  The object structure of a single node of the tree is:   {  // USER-PROVIDED ATTRIBUTES  // ------------------------  type : qx.ui.treevirtual.MTreePrimitive.Type.LEAF,  parentNodeId : 23, // index of the parent node in _nodeArr   label : \MyDocuments\,  bSelected : true, // true if node is selected; false otherwise.  bOpened : true, // true (-), false (+)  bHideOpenClose : false, // whether to hide the open/close button  icon : \images/folder.gif\,  iconSelected : \images/folder_selected.gif\,   cellStyle : \background-color:cyan\  labelStyle : \background-color:red;color:white\   // USER-PROVIDED COLUMN DATA  columnData : [  null, // null at index of tree column (typically 0)  \textofcolumn1\,  \textofcolumn2\  ],   // APPLICATION-, MIXIN-, and SUBCLASS-PROVIDED CUSTOM DATA  data : {  application :  {  // application-specific user data goes in here  foo: \bar\,  ...  },  MDragAndDropSupport :  {  // Data required for the Drag & Drop mixin.  // When a mixin is included, its constructor  // should create this object, named according  // to the mixin or subclass name (empty or  // otherwise)  },  ... // Additional mixins or subclasses.  },   // INTERNALLY-CALCULATED ATTRIBUTES  // --------------------------------  // The following properties need not (and should not) be set by the  // caller, but are automatically calculated. Some are used internally,  // while others may be of use to event listeners.   nodeId : 42, // The index in _nodeArr, useful to event listeners.  children : [ ], // each value is an index into _nodeArr   level : 2, // The indentation level of this tree node   bFirstChild : true,  lastChild : [ false ], // Array where the index is the column of  // indentation, and the value is a boolean.  // These are used to locate the  // appropriate \treeline\ icon. } 
    /// </summary>
    public partial class SimpleTreeDataModel : qxDotNet.UI.Table.Model.Abstract
    {

//        private _var _columnData = null;
//        private _array _data = null;
        private qxDotNet.UI.Treevirtual.TreeVirtual _tree = null;
        private int _treeColumn = 0;


        /// <summary>
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


        protected internal override string GetTypeName()
        {
            return "qx.ui.treevirtual.SimpleTreeDataModel";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("tree", _tree, null);
            state.SetPropertyValue("treeColumn", _treeColumn, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
