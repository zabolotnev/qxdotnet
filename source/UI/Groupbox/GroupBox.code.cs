using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Groupbox
{
    public partial class GroupBox
    {

        protected internal override string GetAddObjectReference(qxDotNet.Core.Object obj)
        {
            if (ItemOptions.ContainsKey((Core.LayoutItem)obj) && ItemOptions[(Core.LayoutItem)obj] != null)
            {
                return GetReference() + ".add(" + obj.GetReference() + "," + base.ItemOptions[(Core.LayoutItem)obj].ToString() + ");\n";
            }
            else
            {
                return GetReference() + ".add(" + obj.GetReference() + ");\n";
            }
        }

        protected internal override string GetRemoveObjectReference(qxDotNet.Core.Object obj)
        {
            return GetReference() + ".remove(" + obj.GetReference() + ");\n";
        }

        public void Add(Core.LayoutItem child)
        {
            Add(child, null);
        }

        public void Add(Core.LayoutItem child, Map options)
        {
            if (Children.Contains(child))
            {
                Remove(child);
            }
            Children.Add(child);
            ItemOptions.Add(child, options);
        }

        public void Remove(Core.LayoutItem child)
        {
            Children.Remove(child);
            ItemOptions.Remove(child);
        }

        public void RemoveAll()
        {
            Children.Clear();
            ItemOptions.Clear();
        }

        public void SetLayout(Layout.Abstract layout)
        {
            _layout = layout;
        }

    }
}
