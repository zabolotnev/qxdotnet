using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Table.Model
{
    internal abstract partial class Abstract
    {

        private bool _modified = true;
        private Table _table;

        public virtual void MarkModified()
        {
            _modified = true;
        }

        public bool Modified
        {
            get
            {
                return _modified;
            }
        }

        public void ResetModified()
        {
            _modified = false;
        }

        /// <summary>
        /// Initialize the table model &lt;--&gt; table interaction. The table model is passed to the table constructor, but the table model doesn’t otherwise know anything about the table nor can it operate on table properties. This function provides the capability for the table model to specify characteristics of the table. It is called when the table model is applied to the table.
        /// </summary>
        /// <param name="table">The table to which this model is attached</param>
        public void Init(Table table)
        {
            _table = table;
        }

        internal Table GetTable()
        {
            return _table;
        }

    }
}
