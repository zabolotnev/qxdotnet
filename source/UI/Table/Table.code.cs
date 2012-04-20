using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using qxDotNet;
using System.Collections;

namespace qxDotNet.UI.Table
{

    public partial class Table : qxDotNet.UI.Core.Widget
    {

        private RemoteModel _model;
        private ColumnCollection _columns;
        private RowCollection _rows;

        private IList _dataSource;
        private bool _needToRefresh = true;
        private List<System.Reflection.PropertyInfo> _accessors;

        public Table()
        {
            _rows = new RowCollection(this);
            _model = new RemoteModel(this);
            _columns = new ColumnCollection(_model);
            SelectionModel = new qxDotNet.UI.Table.Selection.Model();
        }

        public ColumnCollection Columns
        {
            get
            {
                return _columns;
            }
        }

        public IList DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
                Refresh();
            }
        }

        internal RowCollection GetRows()
        {
            if (_accessors == null)
            {
                Refresh();
            }
            return _rows;
        }

        public void Refresh()
        {
            _accessors = null;
            _rows.Clear();
            if (_dataSource != null)
            {
                foreach (var item in _dataSource)
	            {
            		var r = new Row(item);
                    _rows.Add(r);
                    _selectionModel.SelectedIndex = 0;
	            }
            }
            _needToRefresh = true;
        }

        internal void ResetData()
        {
            _accessors = null;
        }

        private void CheckAccessors()
        {
            if (_dataSource == null) return;
            if (_dataSource.Count == 0) return;
            var sample = _dataSource[0];
            if (sample == null) return;
                
            var props = sample.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            _accessors = new List<System.Reflection.PropertyInfo>();
            foreach (var c in Columns)
	        {
        		if (string.IsNullOrEmpty(c.Field))
                {
                    _accessors.Add(null);
                }
                else
                {
                    var cn = c.Field.ToLower();
                    var founded = false;
                    foreach (var p in props)
                    {
                        if (p.Name.ToLower() == cn)
                        {
                            founded = true;
                            _accessors.Add(p);
                            break;
                        }
                    }
                        
                    if (!founded)
                    {
                        _accessors.Add(null);
                    }
                }
                    
	        }
        }

        internal object GetValue(object item, int column)
        {
            CheckAccessors();
            if (_accessors == null) 
            {
                return null;
            }
            if (column >= _accessors.Count) 
            {
                return null;
            }
            if (item == null)
            {
                return null;
            }
            var p = _accessors[column];
            if (p == null)
            {
                return null;
            }
            return p.GetValue(item, null);
        }

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            yield return _model;
            yield return _selectionModel;
        }

        protected internal override void CustomPreRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            Common.TableState.Instance.RegisterModel(_model);
            if (_model.Modified || isRefreshRequest)
            {
                var sb = new StringBuilder();

                sb.AppendLine(_model.GetReference() + "._id_=" + _model.clientId + ";");

                // setColumns
                sb.Append(_model.GetReference() + ".setColumns([");
                var f = false;
                foreach (var item in Columns)
                {
                    if (f)
                    {
                        sb.Append(",");
                    }
                    sb.Append("\"" + item.Name.EscapeToJS() + "\"");
                    f = true;
                }
                sb.Append("],[");
                f = false;
                for (int i = 0; i < Columns.Count; i++)
                {
                    if (f)
                    {
                        sb.Append(",");
                    }
                    sb.Append("\"c" + i.ToString() + "\"");
                    f = true;
                }
                sb.AppendLine("]);");

                response.Write(sb.ToString());
            }
        }

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            if (_model.Modified  || isRefreshRequest)
            {
                var sb = new StringBuilder();

                // TableColumnModel
                var tcm = "tcm" + clientId.ToString();
                sb.AppendLine("var " + tcm + "=" + GetReference() + ".getTableColumnModel();");

                foreach (var item in Columns)
                {
                    var id = Columns.IndexOf(item);
                    if (item.Width > 0)
                    {
                        sb.AppendLine(tcm + ".setColumnWidth(" + id + "," + item.Width + ");");
                    }
                    sb.AppendLine(_model.GetReference() + ".setColumnEditable(" + id + "," + GetClientValue(item.Editable) + ");");
                    sb.AppendLine(_model.GetReference() + ".setColumnSortable(" + id + "," + GetClientValue(item.Sortable) + ");");
                    if (item.CellRenderer != null)
                    {
                        sb.AppendLine(tcm + ".setDataCellRenderer(" + id + "," + item.CellRenderer.GetReference() + ");");
                    }
                    if (item.CellEditor != null)
                    {
                        sb.AppendLine(tcm + ".setCellEditorFactory(" + id + "," + item.CellEditor.GetReference() + ");");
                    }
                }

                response.Write(sb.ToString());
            }
            if (_needToRefresh)
            {
                response.Write(_model.GetReference() + ".reloadData();\n");
                _needToRefresh = false;
            }
            base.CustomPostRender(response, isRefreshRequest);
        }

    }

}
