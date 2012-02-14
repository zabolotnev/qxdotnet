using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    public partial class ToolBar : qxDotNet.UI.Core.Widget
    {

        /// <summary>
        /// Adds a new child widget.
        /// </summary>
        /// <param name="child">the widget to add.</param>
        public void Add(Core.LayoutItem child)
        {
            if (Children.Contains(child))
            {
                Remove(child);
            }
            Children.Add(child);
        }

        /// <summary>
        /// Remove the given child widget.
        /// </summary>
        /// <param name="child">the widget to remove</param>
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
