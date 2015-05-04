using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Core
{
    public partial class Widget : qxDotNet.UI.Core.LayoutItem
    {

        private LayoutCollection _children;
        private ItemOptionCollection _options = new ItemOptionCollection();

        public Widget()
        {
            _children = new LayoutCollection(this);
        }

        protected ItemOptionCollection ItemOptions
        {
            get
            {
                return _options;
            }
        }

        public LayoutCollection Children
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

        protected internal override void CustomPostRender(System.Web.HttpResponse response, bool isRefreshRequest)
        {
            base.CustomPostRender(response, isRefreshRequest);
            if (_needToActivate)
            {
                response.Write(GetReference() + ".activate();\n");
                _needToActivate = false;
            }
            if (_needToFocus)
            {
                response.Write(GetReference() + ".focus();\n");
                _needToFocus = false;
            }
        }

        protected internal override System.Collections.IEnumerable GetChildren(bool isNewOnly)
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

        protected internal override System.Collections.IEnumerable GetRemovedChildren()
        {
            return _children.GetRemovedItems();
        }

        public class ItemOptionCollection : Dictionary<Core.LayoutItem, Map> {}

        private bool _needToActivate = false;

        public void Activate()
        {
            _needToActivate = true;
            OnActivated();
        }

        private bool _needToFocus = false;

        public void Focus()
        {
            _needToFocus = true;
            OnFocused();
        }

    }

    public class LayoutCollection : System.Collections.ObjectModel.Collection<LayoutItem>
    {

        private Widget _parent;

        public LayoutCollection(Widget parent)
        {
            _parent = parent;
        }

        internal Widget Parent
        {
            get
            {
                return _parent;
            }
        }

        private List<LayoutItem> _newItems = new List<LayoutItem>();
        private List<LayoutItem> _removedItems = new List<LayoutItem>();

        protected override void ClearItems()
        {
            foreach (var i in this)
            {
                if (_newItems.Contains(i))
                {
                    _newItems.Remove(i);
                }
                else
                {
                    if (!_removedItems.Contains(i))
                    {
                        _removedItems.Add(i);
                    }
                }
                i.SetOwnerList(null);
            }
            base.ClearItems();
            _newItems.Clear();
        }

        protected override void InsertItem(int index, LayoutItem item)
        {
            base.InsertItem(index, item);
            if (_removedItems.Contains(item))
            {
                _removedItems.Remove(item);
            }
            else
            {
                if (!_newItems.Contains(item))
                {
                    _newItems.Add(item);
                }
            }
            item.SetOwnerList(this);
        }

        public void EnsureAdded(LayoutItem item)
        {
            if (!_newItems.Contains(item))
            {
                _newItems.Add(item);
                item.SetOwnerList(this);
            }
        }

        protected override void RemoveItem(int index)
        {
            var itm = Items[index];
            if (_newItems.Contains(itm))
            {
                _newItems.Remove(itm);
            }
            else
            {
                if (!_removedItems.Contains(itm))
                {
                    _removedItems.Add(itm);
                }
            }
            base.RemoveItem(index);
            itm.SetOwnerList(null);
        }

        protected override void SetItem(int index, LayoutItem item)
        {
            if (!_removedItems.Contains(this[index]))
            {
                _removedItems.Add(this[index]);
            }
            else
            {
                if (!_newItems.Contains(item))
                {
                    _newItems.Add(item);
                }
            }
            this[index].SetOwnerList(null);
            base.SetItem(index, item);
            item.SetOwnerList(this);
        }

        internal void Commit()
        {
            _newItems.Clear();
            _removedItems.Clear();
        }

        internal List<LayoutItem> GetNewItems()
        {
            return _newItems;
        }

        internal List<LayoutItem> GetRemovedItems()
        {
            return _removedItems;
        }

    }
}
