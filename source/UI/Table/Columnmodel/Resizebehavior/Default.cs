using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Columnmodel.Resizebehavior
{
    /// <summary>
    /// The default resize behavior. Until a resize model is loaded, the default behavior is to:     Upon the table initially appearing, and upon any window resize, divide  the table space equally between the visible columns.      When a column is increased in width, all columns to its right are  pushed to the right with no change to their widths. This may push some  columns off the right edge of the table, causing a horizontal scroll  bar to appear.      When a column is decreased in width, if the total width of all columns  is greater than the table width, no additional column width  change is made.      When a column is decreased in width, if the total width of all columns  is less than the table width, the visible column  immediately to the right of the column which decreased in width has its  width increased to fill the remaining space.     A resize model may be loaded to provide more guidance on how to adjust column width upon each of the events: initial appear, window resize, and column resize. *** TO BE FILLED IN ***
    /// </summary>
    public partial class Default : qxDotNet.UI.Table.Columnmodel.Resizebehavior.Abstract
    {

        private bool? _initializeWidthsOnEveryAppear = false;
        private qxDotNet.UI.Table.Columnmodel.Resize _tableColumnModel = null;


        /// <summary>
        /// Whether to reinitialize default widths on each appear event. Typically, one would want to initialize the default widths only upon the first appearance of the table, but the original behavior was to reinitialize it even if the table is hidden and then reshown (e.g. it";s in a pageview and the page is switched and then switched back).
        /// </summary>
        public bool? InitializeWidthsOnEveryAppear
        {
            get
            {
                return _initializeWidthsOnEveryAppear;
            }
            set
            {
               _initializeWidthsOnEveryAppear = value;
            }
        }

        /// <summary>
        /// The table column model in use. Of particular interest is the method getTable which is a reference to the table widget. This allows access to any other features of the table, for use in calculating widths of columns.
        /// </summary>
        public qxDotNet.UI.Table.Columnmodel.Resize TableColumnModel
        {
            get
            {
                return _tableColumnModel;
            }
            set
            {
               _tableColumnModel = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.table.columnmodel.resizebehavior.Default";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("initializeWidthsOnEveryAppear", _initializeWidthsOnEveryAppear, false);
            state.SetPropertyValue("tableColumnModel", _tableColumnModel, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
