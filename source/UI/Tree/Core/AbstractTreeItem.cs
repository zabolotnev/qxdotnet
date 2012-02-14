using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tree.Core
{
    /// <summary>
    /// The AbstractTreeItem serves as a common superclass for the {@link qx.ui.tree.TreeFile} and {@link qx.ui.tree.TreeFolder} classes.
    /// </summary>
    public abstract partial class AbstractTreeItem : qxDotNet.UI.Tree.Core.AbstractItem
    {

        private qxDotNet.UI.Tree.Core.AbstractTreeItem _parent = null;


        /// <summary>
        /// The parent tree folder.
        /// </summary>
        public qxDotNet.UI.Tree.Core.AbstractTreeItem Parent
        {
            get
            {
                return _parent;
            }
            set
            {
               _parent = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.tree.core.AbstractTreeItem";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("parent", _parent, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
