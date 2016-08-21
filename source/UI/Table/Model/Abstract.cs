using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Model
{
    /// <summary>
    /// An abstract table model that performs the column handling, so subclasses only
    /// need to care for row handling.
    /// 
    /// </summary>
    internal abstract partial class Abstract : qxDotNet.Core.Object, qxDotNet.UI.Table.ITableModel
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.model.Abstract";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (DataChanged != null)
            {
                state.SetEvent("dataChanged", false);
            }
            if (MetaDataChanged != null)
            {
                state.SetEvent("metaDataChanged", false);
            }
            if (Sorted != null)
            {
                state.SetEvent("sorted", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "dataChanged")
            {
                OnDataChanged();
            }
            if (eventName == "metaDataChanged")
            {
                OnMetaDataChanged();
            }
            if (eventName == "sorted")
            {
                OnSorted();
            }
        }

        /// <summary>
        /// Raises event 'DataChanged'
        /// </summary>
        protected virtual void OnDataChanged()
        {
            if (DataChanged != null)
            {
                DataChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the table data changed (the stuff shown in the table body).
        /// The data property of the event will be a map having the following
        /// attributes:
        /// 
        ///  firstRow: The index of the first row that has changed.
        ///  lastRow: The index of the last row that has changed.
        ///  firstColumn: The model index of the first column that has changed.
        ///  lastColumn: The model index of the last column that has changed.
        /// 
        /// 
        /// Additionally, if the data changed as a result of rows being removed
        /// from the data model, then these additional attributes will be in the
        /// data:
        /// 
        ///  removeStart: The model index of the first row that was removed.
        ///  removeCount: The number of rows that were removed.
        /// 
        /// 
        /// </summary>
        public event EventHandler DataChanged;

        /// <summary>
        /// Raises event 'MetaDataChanged'
        /// </summary>
        protected virtual void OnMetaDataChanged()
        {
            if (MetaDataChanged != null)
            {
                MetaDataChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the meta data changed (the stuff shown in the table header).
        /// 
        /// </summary>
        public event EventHandler MetaDataChanged;

        /// <summary>
        /// Raises event 'Sorted'
        /// </summary>
        protected virtual void OnSorted()
        {
            if (Sorted != null)
            {
                Sorted.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired after the table is sorted (but before the metaDataChanged event)
        /// 
        /// </summary>
        public event EventHandler Sorted;

    }
}
