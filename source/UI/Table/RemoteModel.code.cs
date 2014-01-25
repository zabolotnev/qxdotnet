using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Table
{

    internal class RemoteModel : qxDotNet.Core.Object
    {

        private Table _owner;

        private bool _modified = true;

        public RemoteModel(Table AOwner)
        {
            _owner = AOwner;
        }

        internal void MarkModified()
        {
            _modified = true;
            ResetData();
        }

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            if (!isNewOnly || _modified)
            {
                foreach (var item in _owner.Columns)
                {
                    if (item.CellRenderer != null)
                    {
                        yield return item.CellRenderer;
                    }
                    if (item.CellEditor != null)
                    {
                        yield return item.CellEditor;
                    }
                }
            }
        }

        protected internal override string GetTypeName()
        {
            return "qxdotnet.table.RemoteDataModel";
        }

        internal void ResetData()
        {
            _owner.ResetData();
        }

        internal int GetColumnsCount()
        {
            return _owner.Columns.Count;
        }

        internal string GetColumnFormat(int columnIndex)
        {
            return _owner.Columns[columnIndex].Format;
        }

        internal int GetRowCount()
        {
            return _owner.GetRows().Count;
        }
        
        internal RowCollection GetRowData()
        {
            return _owner.GetRows();
        }

        internal bool Modified
        {
            get
            {
                return _modified;
            }
        }

        internal void ResetModified()
        {
            _modified = false;
        }

        public void Sort(int columnIndex, bool isDesc)
        {
            _owner.Sort(columnIndex, isDesc);
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            base.CustomPostRender(response, isRefreshRequest);
            ResetModified();
        }

    }

}
