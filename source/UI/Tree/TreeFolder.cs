using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tree
{
    /// <summary>
    /// The tree folder is a tree element, which can have nested tree elements.
    /// </summary>
    public partial class TreeFolder : qxDotNet.UI.Tree.Core.AbstractTreeItem
    {




        public override string GetTypeName()
        {
            return "qx.ui.tree.TreeFolder";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
