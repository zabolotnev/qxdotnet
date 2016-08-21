using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Selection
{
    /// <summary>
    /// A selection manager. This is a helper class that handles all selection
    /// related events and updates a SelectionModel.
    /// 
    /// Widgets that support selection should use this manager. This way the only
    /// thing the widget has to do is mapping pointer or key events to indexes and
    /// call the corresponding handler method.
    /// 
    /// </summary>
    public partial class Manager : qxDotNet.Core.Object
    {

        private qxDotNet.UI.Table.Selection.Model _selectionModel = null;


        /// <summary>
        /// The selection model where to set the selection changes.
        /// 
        /// </summary>
        public qxDotNet.UI.Table.Selection.Model SelectionModel
        {
            get
            {
                return _selectionModel;
            }
            set
            {
               _selectionModel = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.selection.Manager";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selectionModel", _selectionModel, null);


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
