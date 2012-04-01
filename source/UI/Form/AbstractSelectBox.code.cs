using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;
using qxDotNet.UI.Core;

namespace qxDotNet.UI.Form
{

    public abstract partial class AbstractSelectBox : Widget, qxDotNet.UI.Form.IForm
    {

        public void Add(LayoutItem child)
        {
            if (Children.Contains(child))
            {
                Remove(child);
            }
            Children.Add(child);
        }

        public void Remove(LayoutItem child)
        {
            Children.Remove(child);
        }

        public void RemoveAll()
        {
            Children.Clear();
        }

        public LayoutCollection Items
        {
            get
            {
                return Children;
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

    }
}
