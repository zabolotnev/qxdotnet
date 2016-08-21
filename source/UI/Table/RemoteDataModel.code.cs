using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Table
{

    internal class RemoteDataModel : Model.Remote
    {

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            if (!isNewOnly || Modified)
            {
                foreach (var item in GetTable().Columns)
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

        public override void MarkModified()
        {
            base.MarkModified();
            GetTable().ResetData();
        }

        internal int GetColumnsCount()
        {
            return GetTable().Columns.Count;
        }

        internal string GetColumnFormat(int columnIndex)
        {
            return GetTable().Columns[columnIndex].Format;
        }

        internal int GetRowCount()
        {
            return GetTable().GetRows().Count;
        }
        
        internal RowCollection GetRowData()
        {
            return GetTable().GetRows();
        }

        public void Sort(int columnIndex, bool isDesc)
        {
            GetTable().Sort(columnIndex, isDesc);
        }

    }

}
