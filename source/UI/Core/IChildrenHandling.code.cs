using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet.UI.Core
{
    public interface IChildrenHandling
    {
        void Add(LayoutItem child);

        void Add(LayoutItem child, Map options);

        void Remove(LayoutItem child);

        void RemoveAll();
    }
}
