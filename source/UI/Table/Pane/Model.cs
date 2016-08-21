using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Pane
{
    /// <summary>
    /// The model of a table pane. This model works as proxy to a
    /// {@link qx.ui.table.columnmodel.Basic} and manages the visual order of the columns shown in
    /// a {@link Pane}.
    /// 
    /// </summary>
    public partial class Model : qxDotNet.Core.Object
    {

        private int _firstColumnX = 0;
        private decimal _maxColumnCount = -1m;


        /// <summary>
        /// The visible x position of the first column this model should contain.
        /// 
        /// </summary>
        public int FirstColumnX
        {
            get
            {
                return _firstColumnX;
            }
            set
            {
               _firstColumnX = value;
            }
        }

        /// <summary>
        /// The maximum number of columns this model should contain. If -1 this model will
        /// contain all remaining columns.
        /// 
        /// </summary>
        public decimal MaxColumnCount
        {
            get
            {
                return _maxColumnCount;
            }
            set
            {
               _maxColumnCount = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.pane.Model";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("firstColumnX", _firstColumnX, 0);
            state.SetPropertyValue("maxColumnCount", _maxColumnCount, -1m);

            if (ModelChanged != null)
            {
                state.SetEvent("modelChanged", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "modelChanged")
            {
                OnModelChanged();
            }
        }

        /// <summary>
        /// Raises event 'ModelChanged'
        /// </summary>
        protected virtual void OnModelChanged()
        {
            if (ModelChanged != null)
            {
                ModelChanged.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the model changed.
        /// 
        /// </summary>
        public event EventHandler ModelChanged;

    }
}
