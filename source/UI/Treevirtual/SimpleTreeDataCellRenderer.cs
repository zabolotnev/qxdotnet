using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Treevirtual
{
    /// <summary>
    /// A data cell renderer for the tree column of a simple tree  This cell renderer has provisions for subclasses to easily extend the appearance of the tree. If the tree should contain images, labels, etc. before the indentation, the subclass should override the method _addExtraContentBeforeIndentation(). Similarly, content can be added before the icon by overriding _addExtraContentBeforeIcon(), and before the label by overriding _addExtraContentBeforeLabel().  Each of these overridden methods that calls _addImage() can provide, as part of the map passed to _addImage(), a member called "tooltip" which contains the tool tip to present when the mouse is hovered over the image.  If this class is subclassed to form a new cell renderer, an instance of it must be provided, via the "custom"; parameter, to the TreeVirtual constructor.
    /// </summary>
    public partial class SimpleTreeDataCellRenderer : qxDotNet.UI.Table.Cellrenderer.Abstract
    {

        private bool? _alwaysShowOpenCloseSymbol = false;
        private bool? _excludeFirstLevelTreeLines = false;
        private bool? _useTreeLines = true;


        /// <summary>
        /// Set whether the open/close button should be displayed on a branch, even if the branch has no children.
        /// </summary>
        public bool? AlwaysShowOpenCloseSymbol
        {
            get
            {
                return _alwaysShowOpenCloseSymbol;
            }
            set
            {
               _alwaysShowOpenCloseSymbol = value;
            }
        }

        /// <summary>
        /// When true, exclude only the first-level tree lines, creating, effectively, multiple unrelated root nodes.
        /// </summary>
        public bool? ExcludeFirstLevelTreeLines
        {
            get
            {
                return _excludeFirstLevelTreeLines;
            }
            set
            {
               _excludeFirstLevelTreeLines = value;
            }
        }

        /// <summary>
        /// Set whether lines linking tree children shall be drawn on the tree if the theme supports tree lines.
        /// </summary>
        public bool? UseTreeLines
        {
            get
            {
                return _useTreeLines;
            }
            set
            {
               _useTreeLines = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.treevirtual.SimpleTreeDataCellRenderer";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("alwaysShowOpenCloseSymbol", _alwaysShowOpenCloseSymbol, false);
            state.SetPropertyValue("excludeFirstLevelTreeLines", _excludeFirstLevelTreeLines, false);
            state.SetPropertyValue("useTreeLines", _useTreeLines, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
