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
        }

        public void EnsureAdded(LayoutItem item)
        {
            if (!_newItems.Contains(item))
            {
                _newItems.Add(item);
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
            else
            {
                if (!_newItems.Contains(item))
                {
                    _newItems.Add(item);
                }
            }
            base.SetItem(index, item);
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
