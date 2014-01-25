using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Table
{
    public class Row
    {

        private object _bindingItem;
        private Table _owner;

        internal void SetOwner(Table AOwner)
        {
            _owner = AOwner;
        }

        internal Row(object ABindingItem)
        {
            _bindingItem = ABindingItem;
        }
        
        public object GetValue(int column)
        {
            return _owner.GetValue(_bindingItem, column);
        }

        public object BindingItem
        {
            get
            {
                return _bindingItem;
            }
        }

        public int UserIndex { get; set; }

    }

    public class RowCollection : Collection<Row>
    {

        private Table _owner;

        internal RowCollection(Table Owner)
        {
            _owner = Owner;
        }

        protected override void ClearItems()
        {
            base.ClearItems();
        }

        protected override void InsertItem(int index, Row item)
        {
            base.InsertItem(index, item);
            item.SetOwner(_owner);
        }

        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, Row item)
        {
            base.SetItem(index, item);
            item.SetOwner(_owner);
        }

    }

}
