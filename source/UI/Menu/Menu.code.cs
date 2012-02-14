using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;
using qxDotNet.UI.Core;

namespace qxDotNet.UI.Menu
{

    public partial class Menu : qxDotNet.UI.Core.Widget
    {

        public void Add(Core.LayoutItem child)
        {
            if (Children.Contains(child))
            {
                Remove(child);
            }
            Children.Add(child);
        }

        public void Remove(Core.LayoutItem child)
        {
            Children.Remove(child);
        }

        internal override string GetAddObjectReference(qxDotNet.Core.Object obj)
        {
            return GetReference() + ".add(" + obj.GetReference() + ");\n";
        }

        internal override string GetRemoveObjectReference(qxDotNet.Core.Object obj)
        {
            return GetReference() + ".remove(" + obj.GetReference() + ");\n";
        }

    }
}
