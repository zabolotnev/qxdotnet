﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Pane
{
    /// <summary>
    /// The table pane that shows a certain section from a table. This class handles the display of the data part of a table and is therefore the base for virtual scrolling.
    /// </summary>
    public partial class Pane : qxDotNet.UI.Core.Widget
    {

        private decimal _firstVisibleRow = 0;
        private decimal _maxCacheLines = 1000;
        private decimal _visibleRowCount = 0;


        /// <summary>
        /// The index of the first row to show.
        /// </summary>
        public decimal FirstVisibleRow
        {
            get
            {
                return _firstVisibleRow;
            }
            set
            {
               _firstVisibleRow = value;
            }
        }

        /// <summary>
        /// Maximum number of cached rows. If the value is -1 the cache size is unlimited
        /// </summary>
        public decimal MaxCacheLines
        {
            get
            {
                return _maxCacheLines;
            }
            set
            {
               _maxCacheLines = value;
            }
        }

        /// <summary>
        /// The number of rows to show.
        /// </summary>
        public decimal VisibleRowCount
        {
            get
            {
                return _visibleRowCount;
            }
            set
            {
               _visibleRowCount = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.table.pane.Pane";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("firstVisibleRow", _firstVisibleRow, 0);
            state.SetPropertyValue("maxCacheLines", _maxCacheLines, 1000);
            state.SetPropertyValue("visibleRowCount", _visibleRowCount, 0);

            if (PaneReloadsData != null)
            {
                state.SetEvent("paneReloadsData", false);
            }
            if (PaneUpdated != null)
            {
                state.SetEvent("paneUpdated", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "paneReloadsData")
            {
                OnPaneReloadsData();
            }
            if (eventName == "paneUpdated")
            {
                OnPaneUpdated();
            }
        }

        protected virtual void OnPaneReloadsData()
        {
            if (PaneReloadsData != null)
            {
                PaneReloadsData.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Whether the current view port of the pane has not loaded data. The data object of the event indicates if the table pane has to reload data or not. Can be used to give the user feedback of the loading state of the rows.
        /// </summary>
        public event EventHandler PaneReloadsData;

        protected virtual void OnPaneUpdated()
        {
            if (PaneUpdated != null)
            {
                PaneUpdated.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Whenever the content of the table panehas been updated (rendered) trigger a paneUpdated event. This allows the canvas cellrenderer to act once the new cells have been integrated in the dom.
        /// </summary>
        public event EventHandler PaneUpdated;

    }
}
