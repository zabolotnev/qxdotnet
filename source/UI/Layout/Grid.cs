using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// The grid layout manager arranges the items in a two dimensional grid. Widgets can be placed into the grid&#8217;s cells and may span multiple rows and columns.  Features   Flex values for rows and columns Minimal and maximal column and row sizes Manually setting of column and row sizes Horizontal and vertical alignment Horizontal and vertical spacing Column and row spans Auto-sizing   Item Properties   row (Integer): The row of the cell the  widget should occupy. Each cell can only contain one widget. This layout  property is mandatory.  column (Integer): The column of the cell the  widget should occupy. Each cell can only contain one widget. This layout  property is mandatory.  rowSpan (Integer): The number of rows, the  widget should span, starting from the row specified in the row  property. The cells in the spanned rows must be empty as well.  colSpan (Integer): The number of columns, the  widget should span, starting from the column specified in the column  property. The cells in the spanned columns must be empty as well.    Example  Here is a little example of how to use the grid layout.   var layout = new qx.ui.layout.Grid(); layout.setRowFlex(0, 1); // make row 0 flexible layout.setColumnWidth(1, 200); // set with of column 1 to 200 pixel  var container = new qx.ui.container.Composite(layout); container.add(new qx.ui.core.Widget(), {row: 0, column: 0}); container.add(new qx.ui.core.Widget(), {row: 0, column: 1}); container.add(new qx.ui.core.Widget(), {row: 1, column: 0, rowSpan: 2});   External Documentation   Extended documentation and links to demos of this layout in the qooxdoo manual.
    /// </summary>
    public partial class Grid : qxDotNet.UI.Layout.Abstract
    {

        private int _spacingX = 0;
        private int _spacingY = 0;
        private Map _columnAlign = null;
        private int _columnFlex = 0;
        private int _columnMaxWidth = 0;
        private int _columnMinWidth = 0;
        private int _columnWidth = 0;
        private Map _rowAlign = null;
        private int _rowFlex = 0;
        private int _rowHeight = 0;
        private int _rowMaxHeight = 0;
        private int _rowMinHeight = 0;


        /// <summary>
        /// The horizontal spacing between grid cells.
        /// </summary>
        public int SpacingX
        {
            get
            {
                return _spacingX;
            }
            set
            {
               _spacingX = value;
            }
        }

        /// <summary>
        /// The vertical spacing between grid cells.
        /// </summary>
        public int SpacingY
        {
            get
            {
                return _spacingY;
            }
            set
            {
               _spacingY = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Map ColumnAlign
        {
            get
            {
                return _columnAlign;
            }
            set
            {
               _columnAlign = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ColumnFlex
        {
            get
            {
                return _columnFlex;
            }
            set
            {
               _columnFlex = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ColumnMaxWidth
        {
            get
            {
                return _columnMaxWidth;
            }
            set
            {
               _columnMaxWidth = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ColumnMinWidth
        {
            get
            {
                return _columnMinWidth;
            }
            set
            {
               _columnMinWidth = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ColumnWidth
        {
            get
            {
                return _columnWidth;
            }
            set
            {
               _columnWidth = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Map RowAlign
        {
            get
            {
                return _rowAlign;
            }
            set
            {
               _rowAlign = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int RowFlex
        {
            get
            {
                return _rowFlex;
            }
            set
            {
               _rowFlex = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int RowHeight
        {
            get
            {
                return _rowHeight;
            }
            set
            {
               _rowHeight = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int RowMaxHeight
        {
            get
            {
                return _rowMaxHeight;
            }
            set
            {
               _rowMaxHeight = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int RowMinHeight
        {
            get
            {
                return _rowMinHeight;
            }
            set
            {
               _rowMinHeight = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.layout.Grid";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("spacingX", _spacingX, 0);
            state.SetPropertyValue("spacingY", _spacingY, 0);
            state.SetPropertyValue("columnAlign", _columnAlign, null);
            state.SetPropertyValue("columnFlex", _columnFlex, 0);
            state.SetPropertyValue("columnMaxWidth", _columnMaxWidth, 0);
            state.SetPropertyValue("columnMinWidth", _columnMinWidth, 0);
            state.SetPropertyValue("columnWidth", _columnWidth, 0);
            state.SetPropertyValue("rowAlign", _rowAlign, null);
            state.SetPropertyValue("rowFlex", _rowFlex, 0);
            state.SetPropertyValue("rowHeight", _rowHeight, 0);
            state.SetPropertyValue("rowMaxHeight", _rowMaxHeight, 0);
            state.SetPropertyValue("rowMinHeight", _rowMinHeight, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
