using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{

    public abstract partial class LayoutItem
    {
        private LayoutCollection _ownerList;

        internal void SetOwnerList(LayoutCollection ownerList)
        {
            _ownerList = ownerList;
        }

        public Widget Parent
        {
            get
            {
                if (_ownerList == null)
                {
                    return null;
                }
                return _ownerList.Parent;
            }
        }

        protected static T FindParent<T>(UI.Core.LayoutItem item)
            where T : UI.Core.Widget
        {
            if (item.Parent == null)
            {
                return default(T);
            }
            if (item.Parent is T)
            {
                return (T)item.Parent;
            }
            return FindParent<T>(item.Parent);
        }

    }
}
