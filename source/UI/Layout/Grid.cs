using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// The grid layout manager arranges the items in a two dimensional
    /// grid. Widgets can be placed into the grid's cells and may span multiple rows
    /// and columns.
    /// 
    /// Features
    /// 
    /// 
    /// Flex values for rows and columns
    /// Minimal and maximal column and row sizes
    /// Manually setting of column and row sizes
    /// Horizontal and vertical alignment
    /// Horizontal and vertical spacing
    /// Column and row spans
    /// Auto-sizing
    /// 
    /// 
    /// Item Properties
    /// 
    /// 
    /// row (Integer): The row of the cell the
    ///  widget should occupy. Each cell can only contain one widget. This layout
    ///  property is mandatory.
    /// 
    /// column (Integer): The column of the cell the
    ///  widget should occupy. Each cell can only contain one widget. This layout
    ///  property is mandatory.
    /// 
    /// rowSpan (Integer): The number of rows, the
    ///  widget should span, starting from the row specified in the row
    ///  property. The cells in the spanned rows must be empty as well.
    /// 
    /// colSpan (Integer): The number of columns, the
    ///  widget should span, starting from the column specified in the column
    ///  property. The cells in the spanned columns must be empty as well.
    /// 
    /// 
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the grid layout.
    /// 
    /// 
    /// var layout = new qx.ui.layout.Grid();
    /// layout.setRowFlex(0, 1); // make row 0 flexible
    /// layout.setColumnWidth(1, 200); // set with of column 1 to 200 pixel
    /// 
    /// var container = new qx.ui.container.Composite(layout);
    /// container.add(new qx.ui.core.Widget(), {row: 0, column: 0});
    /// container.add(new qx.ui.core.Widget(), {row: 0, column: 1});
    /// container.add(new qx.ui.core.Widget(), {row: 1, column: 0, rowSpan: 2});
    /// 
    /// 
    /// External Documentation
    /// 
    /// 
    /// Extended documentation and links to demos of this layout in the qooxdoo manual.
    /// </summary>
    public partial class Grid : qxDotNet.UI.Layout.Abstract
    {

        private int _spacingX = 0;
        private int _spacingY = 0;


        /// <summary>
        /// The horizontal spacing between grid cells.
        /// 
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
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Grid";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("spacingX", _spacingX, 0);
            state.SetPropertyValue("spacingY", _spacingY, 0);


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
