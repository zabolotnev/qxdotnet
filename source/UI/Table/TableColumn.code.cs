using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace qxDotNet.UI.Table
{

    public class Column
    {

        private RemoteDataModel _owner;
        private string _name = "";
        private string _field = "";
        private bool _sortable = true;
        private bool _editable = false;
        private int _width = 0;
        private Cellrenderer.Abstract _cellRenderer;
        private Celleditor.AbstractField _cellEditor;
        private string _format;
        private Func<Row, object, object> _calculateAction;

        internal void setOwner(RemoteDataModel owner)
        {
            _owner = owner;
        }

        private void modelModified()
        {
            if (_owner != null)
            {
                _owner.MarkModified();
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                modelModified();
            }
        }

        public string Format
        {
            get
            {
                return _format;
            }
            set
            {
                _format = value;
                modelModified();
            }
        }

        public string Field
        {
            get
            {
                return _field;
            }
            set
            {
                _field = value;
                if (_owner != null)
                {
                    _owner.GetTable().ResetData();
                }
            }
        }


        public bool Sortable
        {
            get
            {
                return _sortable;
            }
            set
            {
                _sortable = value;
                modelModified();
            }
        }

        public bool Editable
        {
            get
            {
                return _editable;
            }
            set
            {
                _editable = value;
                modelModified();
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                modelModified();
            }
        }

        public Cellrenderer.Abstract CellRenderer
        {
            get
            {
                return _cellRenderer;
            }
            set
            {
                _cellRenderer = value;
                modelModified();
            }
        }

        public Celleditor.AbstractField CellEditor
        {
            get
            {
                return _cellEditor;
            }
            set
            {
                _cellEditor = value;
                modelModified();
            }
        }

        public Func<Row, object, object> CalculateAction
        {
            get
            {
                return _calculateAction;
            }
            set
            {
                _calculateAction = value;
                modelModified();
            }
        }

    }

    public class ColumnCollection : Collection<Column>
    {
        private RemoteDataModel _model;

        internal ColumnCollection(RemoteDataModel Model)
        {
            _model = Model;
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            _model.MarkModified();
        }

        protected override void InsertItem(int index, Column item)
        {
            base.InsertItem(index, item);
            _model.MarkModified();
        }

        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
            _model.MarkModified();
        }

        protected override void SetItem(int index, Column item)
        {
            base.SetItem(index, item);
            _model.MarkModified();
        }

    }

}
