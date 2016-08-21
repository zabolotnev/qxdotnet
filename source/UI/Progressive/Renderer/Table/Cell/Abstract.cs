using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Progressive.Renderer.Table.Cell
{
    /// <summary>
    /// Cell Renderer for Progressive's Table.
    /// 
    /// Many of the methods in this class accept a parameter called cellInfo. This
    /// parameter is an object with the following members:
    /// 
    /// 
    ///  
    ///  state
    ///  
    ///  
    ///  The {@link qx.ui.progressive.State} object pertaining to this rendering
    ///  session.
    ///  
    /// 
    /// 
    ///  rowDiv
    ///  
    ///  
    ///  The "div" DOM element of the row in which this cell is to be added.
    ///  
    /// 
    /// 
    ///  element
    ///  
    ///  
    ///  The entire element object returned by the data model.
    ///  
    /// 
    /// 
    ///  dataIndex
    ///  
    ///  
    ///  The index into the data element provided by the data model.
    ///  Effectively, this is the column number.
    ///  
    /// 
    /// 
    ///  cellData
    ///  
    ///  
    ///  The data from the data model, to be rendered. This the specific column
    ///  data for the column being rendered, and is a shorthand for
    ///  element.data[element.dataIndex].
    ///  
    /// 
    /// 
    ///  height Input/Output parameter!
    ///  
    ///  
    ///  On input to a cell renderer, this contains the height, as determined to
    ///  date, for the current row. The first column being rendered will
    ///  receive a height of zero. Upon return, it may leave the height at
    ///  zero, meaning that it will accept any minimum height, or may specify a
    ///  minimum height by setting this member. Subsequent column cell renderers
    ///  will receive the maximum height specified by any previous cell
    ///  renderer. Upon completion of calling each of the cell renderers for a
    ///  row, the row height will be set to the value found in this member.
    ///  
    /// 
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.progressive.renderer.table.cell.Abstract";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


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
