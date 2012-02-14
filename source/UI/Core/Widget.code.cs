using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Core
{
    public partial class Widget : qxDotNet.UI.Core.LayoutItem
    {

        private LayoutCollection _children = new LayoutCollection();
        private ItemOptionCollection _options = new ItemOptionCollection();

        protected ItemOptionCollection ItemOptions
        {
            get
            {
                return _options;
            }
        }

        internal LayoutCollection Children
        {
            get
            {
                return _children;
            }
        }

        internal override void Commit()
        {
            base.Commit();
            _children.Commit();
        }

        internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
        {
            if (isNewOnly)
            {
                return _children.GetNewItems();
            }
            else
            {
                return _children;
            }
        }

        internal override System.Collections.IEnumerable GetRemovedChildren()
        {
            return _children.GetRemovedItems();
        }

        public class ItemOptionCollection : Dictionary<Core.LayoutItem, Map> {}

    }

    internal class LayoutCollection : System.Collections.ObjectModel.Collection<LayoutItem>
    {
        private List<LayoutItem> _newItems = new List<LayoutItem>();
        private List<LayoutItem> _removedItems = new List<LayoutItem>();

        protected override void ClearItems()
        {
            foreach (var i in this)
            {
                _removedItems.Add(i);
            }
            base.ClearItems();
            _newItems.Clear();
        }

        protected override void InsertItem(int index, LayoutItem item)
        {
            base.InsertItem(index, item);
            if (!_newItems.Contains(item))
            {
                _newItems.Add(item);
            }
            if (_removedItems.Contains(item))
            {
                _removedItems.Remove(item);
            }
        }

        protected override void RemoveItem(int index)
        {
            var itm = Items[index];
            if (_newItems.Contains(itm))
            {
                _newItems.Remove(itm);
            }
            if (!_removedItems.Contains(itm))
            {
                _removedItems.Add(itm);
            }
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, LayoutItem item)
        {
            if (!_removedItems.Contains(this[index]))
            {
                _removedItems.Add(this[index]);
            }
            base.SetItem(index, item);
            if (!_newItems.Contains(item))
            {
                _newItems.Add(item);
            }
        }

        public void Commit()
        {
            _newItems.Clear();
            _removedItems.Clear();
        }

        public List<LayoutItem> GetNewItems()
        {
            return _newItems;
        }

        public List<LayoutItem> GetRemovedItems()
        {
            return _removedItems;
        }

    }
}
