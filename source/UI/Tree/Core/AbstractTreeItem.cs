using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tree.Core
{
    /// <summary>
    /// The AbstractTreeItem serves as a common superclass for the {@link
    /// qx.ui.tree.TreeFile} and {@link qx.ui.tree.TreeFolder} classes.
    /// 
    /// </summary>
    public abstract partial class AbstractTreeItem : qxDotNet.UI.Tree.Core.AbstractItem
    {

        private qxDotNet.UI.Tree.Core.AbstractTreeItem _parent = null;


        /// <summary>
        /// The parent tree folder.
        /// 
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


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tree.core.AbstractTreeItem";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("parent", _parent, null);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
