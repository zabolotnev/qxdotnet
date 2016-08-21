using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Model
{
    /// <summary>
    /// A table model that loads its data from a backend.
    /// 
    /// Only a subset of the available rows, those which are within or near the
    /// currently visible area, are loaded. If a quick scroll operation occurs,
    /// rows will soon be displayed using asynchronous loading in the background.
    /// All loaded data is managed through a cache which automatically removes
    /// the oldest used rows when it gets full.
    /// 
    /// This class is abstract: The actual loading of row data must be done by
    /// subclasses.
    /// 
    /// </summary>
    internal partial class Remote : qxDotNet.UI.Table.Model.Abstract
    {

        private bool? _blockConcurrentLoadRowCount = true;
        private int _blockSize = 50;
        private bool? _clearCacheOnRemove = false;
        private int _maxCachedBlockCount = 15;


        /// <summary>
        /// Whether to block remote requests for the row count while a request for
        /// the row count is pending. Row counts are requested at various times and
        /// from various parts of the code, resulting in numerous requests to the
        /// user-provided _loadRowCount() method, often while other requests are
        /// already pending. The default behavior now ignores requests to load a
        /// new row count if such a request is already pending. It is therefore now
        /// conceivable that the row count changes between an initial request for
        /// the row count and a later (ignored) request. Since the chance of this
        /// is low, the desirability of reducing the server requests outweighs the
        /// slight possibility of an altered count (which will, by the way, be
        /// detected soon thereafter upon the next request for the row count). If
        /// the old behavior is desired, set this property to false.
        /// 
        /// </summary>
        public bool? BlockConcurrentLoadRowCount
        {
            get
            {
                return _blockConcurrentLoadRowCount;
            }
            set
            {
               _blockConcurrentLoadRowCount = value;
            }
        }

        /// <summary>
        /// The number of rows that are stored in one cache block.
        /// 
        /// </summary>
        public int BlockSize
        {
            get
            {
                return _blockSize;
            }
            set
            {
               _blockSize = value;
            }
        }

        /// <summary>
        /// Whether to clear the cache when some rows are removed.
        /// If true the rows are removed locally in the cache.
        /// 
        /// </summary>
        public bool? ClearCacheOnRemove
        {
            get
            {
                return _clearCacheOnRemove;
            }
            set
            {
               _clearCacheOnRemove = value;
            }
        }

        /// <summary>
        /// The maximum number of row blocks kept in the cache.
        /// 
        /// </summary>
        public int MaxCachedBlockCount
        {
            get
            {
                return _maxCachedBlockCount;
            }
            set
            {
               _maxCachedBlockCount = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.model.Remote";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("blockConcurrentLoadRowCount", _blockConcurrentLoadRowCount, true);
            state.SetPropertyValue("blockSize", _blockSize, 50);
            state.SetPropertyValue("clearCacheOnRemove", _clearCacheOnRemove, false);
            state.SetPropertyValue("maxCachedBlockCount", _maxCachedBlockCount, 15);


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
