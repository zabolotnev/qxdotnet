using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tabview
{
    public partial class TabView : qxDotNet.UI.Core.Widget, qxDotNet.UI.Core.ISingleSelection
    {

        private PageCollection _pages;

        public TabView()
        {
            _pages = new PageCollection(this);
        }

        public void Add(Page child)
        {
            if (_pages.Contains(child))
            {
                Remove(child);
            }
            _pages.Add(child);
        }

        public void Remove(Page child)
        {
            _pages.Remove(child);
        }

        public void RemoveAll()
        {
            _pages.Clear();
        }

        public PageCollection Pages
        {
            get
            {
                return _pages;
            }
        }

        protected internal override string GetAddObjectReference(qxDotNet.Core.Object obj)
        {
            return GetReference() + ".add(" + obj.GetReference() + ");\n";
        }

        protected internal override string GetRemoveObjectReference(qxDotNet.Core.Object obj)
        {
            return GetReference() + ".remove(" + obj.GetReference() + ");\n";
        }

        protected internal override string GetGetPropertyAccessor(string name, bool isRef)
        {
            if (name == "selection")
            {
                return GetReference() + ".getSelection().pop()._id_";
            }
            else
            {
                return base.GetGetPropertyAccessor(name, isRef);
            }
        }

        protected internal override string GetSetPropertyValueExpression(string name, object value)
        {
            if (name == "selection")
            {
                if (value == null)
                {
                    return GetReference() + "." + GetSetPropertyAccessor(name) + "([]);\n";
                }
                else
                {
                    return GetReference() + "." + GetSetPropertyAccessor(name) + "([" + GetClientValue(value) + "]);\n";
                }
            }
            else
            {
                return base.GetSetPropertyValueExpression(name, value);
            }
        }

        #region ISingleSelection Members

        qxDotNet.UI.Core.Widget qxDotNet.UI.Core.ISingleSelection.Selection
        {
            get
            {
                return _selection;
            }
            set
            {
                _selection = (Page)value;
            }
        }

        #endregion

    }

    public class PageCollection : System.Collections.ObjectModel.Collection<Page>
    {

        private TabView _owner;

        internal PageCollection(TabView owner)
        {
            _owner = owner;
        }

        protected override void ClearItems()
        {
            foreach (var i in _owner.Children.ToList())
            {
                _owner.Children.Remove(i);
            }
            base.ClearItems();
        }

        protected override void InsertItem(int index, Page item)
        {
            base.InsertItem(index, item);
            _owner.Children.Insert(index, item);
        }

        protected override void RemoveItem(int index)
        {
            var itm = this[index];
            if (_owner.Selection == itm)
            {
                _owner.Selection = null;
            }
            base.RemoveItem(index);
            _owner.Children.RemoveAt(index);
        }

        protected override void SetItem(int index, Page item)
        {
            var itm = this[index];
            if (_owner.Selection == itm)
            {
                _owner.Selection = null;
            }
            base.SetItem(index, item);
            _owner.Children.RemoveAt(index);
            _owner.Children.Insert(index, item);
        }

    }

}
