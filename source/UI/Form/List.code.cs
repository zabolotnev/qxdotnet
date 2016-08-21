using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;
using qxDotNet.UI.Core;

namespace qxDotNet.UI.Form
{

    public partial class List : qxDotNet.UI.Core.Scroll.AbstractScrollArea, qxDotNet.UI.Core.IMultiSelection, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.IModelSelection
    {

        protected internal override string GetAddObjectReference(qxDotNet.Core.Object obj)
        {
            if (ItemOptions.ContainsKey((LayoutItem)obj) && ItemOptions[(LayoutItem)obj] != null)
            {
                return GetReference() + ".add(" + obj.GetReference() + "," + base.ItemOptions[(LayoutItem)obj].ToString() + ");\n";
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

        public void Add(LayoutItem child)
        {
            Add(child, null);
        }

        public void Add(LayoutItem child, Map options)
        {
            if (Children.Contains(child))
            {
                Remove(child);
            }
            Children.Add(child);
            if (!ItemOptions.ContainsKey(child))
            {
                ItemOptions.Add(child, options);
            }
            else
            {
                if (options != null)
                {
                    if (!options.Equals(ItemOptions[child]))
                    {
                        Children.EnsureAdded(child);
                    }
                }
            }
        }

        public void Remove(LayoutItem child)
        {
            Children.Remove(child);
        }

        public void RemoveAll()
        {
            Children.Clear();
            ItemOptions.Clear();
        }


    }
}
