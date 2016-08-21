using qxDotNet.UI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Layout
{
    public partial class Grid : qxDotNet.UI.Layout.Abstract
    {

        ///// <summary>
        ///// Get a map of the cell’s alignment. For vertical alignment the row alignment takes precedence over the column alignment. For horizontal alignment it is the over way round. 
        ///// If an alignment is set on the cell widget using qx.ui.core.LayoutItem#setLayoutProperties, this alignment takes always precedence over row or column alignment.
        ///// </summary>
        ///// <param name="row">The cell’s row index</param>
        ///// <param name="column">The cell’s column index</param>
        ///// <returns>A map with the keys vAlign and hAlign containing the vertical and horizontal cell alignment.</returns>
        //public Map GetCellAlign(int row, int column)
        //{

        //}

        ///// <summary>
        ///// Get the widget located in the cell. If a the cell is empty or the widget has a qx.ui.core.Widget#visibility value of exclude, null is returned.
        ///// </summary>
        ///// <param name="row">The cell’s row index</param>
        ///// <param name="column">The cell’s column index</param>
        ///// <returns>The cell’s widget. The value may be null.</returns>
        //public Widget GetCellWidget(int row, int column)
        //{

        //}

        ///// <summary>
        ///// Get the number of columns in the grid layout.
        ///// </summary>
        ///// <returns>The number of columns in the layout</returns>
        //public int GetColumnCount()
        //{

        //}

        ///// <summary>
        ///// Get the number of rows in the grid layout.
        ///// </summary>
        ///// <returns>The number of rows in the layout</returns>
        //public int GetRowCount()
        //{

        //}

        /// <summary>
        /// Get a map of the column’s alignment.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <returns>A map with the keys vAlign and hAlign containing the vertical and horizontal column alignment.</returns>
        public Map GetColumnAlign(int column)
        {
            if (_columnAlign.ContainsKey(column))
            {
                return _columnAlign[column];
            }
            return null;
        }

        /// <summary>
        /// Get the flex value of a grid column.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <returns>The column’s flex value</returns>
        public int GetColumnFlex(int column)
        {
            if (_columnFlex.ContainsKey(column))
            {
                return _columnFlex[column];
            }
            return 0;
        }

        /// <summary>
        /// Get the maximum width of a grid column.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <returns>The column’s maximum width</returns>
        public int? GetColumnMaxWidth(int column)
        {
            if (_columnMaxWidth.ContainsKey(column))
            {
                return _columnMaxWidth[column];
            }
            return null;
        }

        /// <summary>
        /// Get the minimum width of a grid column.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <returns>The column’s minimum width</returns>
        public int? GetColumnMinWidth(int column)
        {
            if (_columnMinWidth.ContainsKey(column))
            {
                return _columnMinWidth[column];
            }
            return null;
        }

        /// <summary>
        /// Get the preferred width of a grid column.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <returns>The column’s width</returns>
        public int? GetColumnWidth(int column)
        {
            if (_columnWidth.ContainsKey(column))
            {
                return _columnWidth[column];
            }
            return null;
        }

        /// <summary>
        /// Get a map of the row’s alignment.
        /// </summary>
        /// <param name="row">The Row index</param>
        /// <returns>A map with the keys vAlign and hAlign containing the vertical and horizontal row alignment.</returns>
        public Map GetRowAlign(int row)
        {
            if (_rowAlign.ContainsKey(row))
            {
                return _rowAlign[row];
            }
            return null;
        }

        /// <summary>
        /// Get the flex value of a grid row.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <returns>The row’s flex value</returns>
        public int GetRowFlex(int row)
        {
            if (_rowFlex.ContainsKey(row))
            {
                return _rowFlex[row];
            }
            return 0;
        }

        /// <summary>
        /// Get the preferred height of a grid row.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <returns>The row’s width</returns>
        public int? GetRowHeight(int row)
        {
            if (_rowHeight.ContainsKey(row))
            {
                return _rowHeight[row];
            }
            return null;
        }

        /// <summary>
        /// Get the maximum height of a grid row.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <returns>The row’s maximum width</returns>
        public int? GetRowMaxHeight(int row)
        {
            if (_rowMaxHeight.ContainsKey(row))
            {
                return _rowMaxHeight[row];
            }
            return null;
        }

        /// <summary>
        /// Get the minimum height of a grid row.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <returns>The row’s minimum width</returns>
        public int? GetRowMinHeight(int row)
        {
            if (_rowMinHeight.ContainsKey(row))
            {
                return _rowMinHeight[row];
            }
            return null;
        }

        private Dictionary<int, Map> _columnAlign = new Dictionary<int, Map>();

        /// <summary>
        /// Set the default cell alignment for a column. This alignment can be overridden on a per cell basis by setting the cell’s content widget’s alignX and alignY properties.
        /// If on a grid cell both row and a column alignment is set, the horizontal alignment is taken from the column and the vertical alignment is taken from the row.
        /// </summary>
        /// <param name="column">Column index</param>
        /// <param name="hAlign">The horizontal alignment.Valid values are “left”, “center” and “right”.</param>
        /// <param name="vAlign">The vertical alignment. Valid values are “top”, “middle”, “bottom”</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetColumnAlign(int column, AlignXEnum  hAlign, AlignYEnum vAlign)
        {
            var map = new Map()
                .Add(nameof(hAlign), hAlign)
                .Add(nameof(vAlign), vAlign);
            _columnAlign[column] = map;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setColumnAlign")
                .SetKeyParameter(column)
                .SetParameter(hAlign)
                .SetParameter(vAlign));

            return this;
        }

        private Dictionary<int, int> _columnFlex = new Dictionary<int, int>();

        /// <summary>
        /// Set the flex value for a grid column. By default the column flex value is 0.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <param name="flex">The column’s flex value</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetColumnFlex(int column, int flex)
        {
            _columnFlex[column] = flex;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setColumnFlex")
                .SetKeyParameter(column)
                .SetParameter(flex));

            return this;
        }

        private Dictionary<int, int?> _columnMaxWidth = new Dictionary<int, int?>();

        /// <summary>
        /// Set the maximum width of a grid column.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <param name="maxWidth">The column’s maximum width</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetColumnMaxWidth(int column, int? maxWidth)
        {
            _columnMaxWidth[column] = maxWidth;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setColumnMaxWidth")
                .SetKeyParameter(column)
                .SetParameter(maxWidth));

            return this;
        }

        private Dictionary<int, int?> _columnMinWidth = new Dictionary<int, int?>();

        /// <summary>
        /// Set the minimum width of a grid column. The default value is 0.
        /// </summary>
        /// <param name="column">The column index</param>
        /// <param name="minWidth">The column’s minimum width</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetColumnMinWidth(int column, int? minWidth)
        {
            _columnMinWidth[column] = minWidth;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setColumnMinWidth")
                .SetKeyParameter(column)
                .SetParameter(minWidth));

            return this;
        }

        private Dictionary<int, int?> _columnWidth = new Dictionary<int, int?>();

        /// <summary>
        /// Set the preferred width of a grid column. The default value is Infinity.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="width"></param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetColumnWidth(int column, int? width)
        {
            _columnWidth[column] = width;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setColumnWidth")
                .SetKeyParameter(column)
                .SetParameter(width));

            return this;
        }

        private Dictionary<int, Map> _rowAlign = new Dictionary<int, Map>();

        /// <summary>
        /// Set the default cell alignment for a row. This alignment can be overridden on a per cell basis by setting the cell’s content widget’s alignX and alignY properties.
        /// If on a grid cell both row and a column alignment is set, the horizontal alignment is taken from the column and the vertical alignment is taken from the row.
        /// </summary>
        /// <param name="row">Row index</param>
        /// <param name="hAlign">The horizontal alignment. Valid values are “left”, “center” and “right”.</param>
        /// <param name="vAlign">The vertical alignment. Valid values are “top”, “middle”, “bottom”</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetRowAlign(int row, AlignXEnum hAlign, AlignYEnum vAlign)
        {
            var map = new Map()
                .Add(nameof(hAlign), hAlign)
                .Add(nameof(vAlign), vAlign);
            _rowAlign[row] = map;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setRowAlign")
                .SetKeyParameter(row)
                .SetParameter(hAlign)
                .SetParameter(vAlign));

            return this;
        }

        private Dictionary<int, int> _rowFlex = new Dictionary<int, int>();

        /// <summary>
        /// Set the flex value for a grid row. By default the row flex value is 0.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="flex">The row’s flex value</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetRowFlex(int row, int flex)
        {
            _rowFlex[row] = flex;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setRowFlex")
                .SetKeyParameter(row)
                .SetParameter(flex));

            return this;
        }

        private Dictionary<int, int?> _rowHeight = new Dictionary<int, int?>();

        /// <summary>
        /// Set the preferred height of a grid row. The default value is Infinity.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="height">The row’s width</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetRowHeight(int row, int? height)
        {
            _rowHeight[row] = height;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setRowHeight")
                .SetKeyParameter(row)
                .SetParameter(height));

            return this;
        }

        private Dictionary<int, int?> _rowMaxHeight = new Dictionary<int, int?>();

        /// <summary>
        /// Set the maximum height of a grid row. The default value is Infinity.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="maxHeight">The row’s maximum width</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetRowMaxHeight(int row, int? maxHeight)
        {
            _rowMaxHeight[row] = maxHeight;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setRowMaxHeight")
                .SetKeyParameter(row)
                .SetParameter(maxHeight));

            return this;
        }

        private Dictionary<int, int?> _rowMinHeight = new Dictionary<int, int?>();

        /// <summary>
        /// Set the minimum height of a grid row. The default value is 0.
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="minHeight">The row’s minimum width</param>
        /// <returns>This object (for chaining support)</returns>
        public Grid SetRowMinHeight(int row, int? minHeight)
        {
            _rowMinHeight[row] = minHeight;

            CallClientMethod(
                new qxDotNet.Core.ClientMethodCall("setRowMinHeight")
                .SetKeyParameter(row)
                .SetParameter(minHeight));

            return this;
        }

        /// <summary>
        /// Shortcut to set both horizontal and vertical spacing between grid cells to the same value.
        /// </summary>
        /// <param name="spacing">new horizontal and vertical spacing</param>
        /// <returns>This object (for chaining support).</returns>
        public Grid SetSpacing(int spacing)
        {
            this.SpacingX = spacing;
            this.SpacingY = spacing;
            return this;
        }

    }
}
