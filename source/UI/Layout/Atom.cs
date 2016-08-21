using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// A atom layout. Used to place an image and label in relation
    /// to each other. Useful to create buttons, list items, etc.
    /// 
    /// Features
    /// 
    /// 
    /// Gap between icon and text (using {@link #gap})
    /// Vertical and horizontal mode (using {@link #iconPosition})
    /// Sorting options to place first child on top/left or bottom/right (using {@link #iconPosition})
    /// Automatically middles/centers content to the available space
    /// Auto-sizing
    /// Supports more than two children (will be processed the same way like the previous ones)
    /// 
    /// 
    /// Item Properties
    /// 
    /// None
    /// 
    /// Notes
    /// 
    /// 
    /// Does not support margins and alignment of {@link qx.ui.core.LayoutItem}.
    /// 
    /// 
    /// Alternative Names
    /// 
    /// None
    /// 
    /// </summary>
    public partial class Atom : qxDotNet.UI.Layout.Abstract
    {

        private bool? _center = false;
        private int _gap = 4;
        private qxDotNet.IconPositionEnum _iconPosition = IconPositionEnum.left;


        /// <summary>
        /// Whether the content should be rendered centrally when to much space
        /// is available. Enabling this property centers in both axis. The behavior
        /// when disabled of the centering depends on the {@link #iconPosition} property.
        /// If the icon position is left or right, the X axis
        /// is not centered, only the Y axis. If the icon position is top
        /// or bottom, the Y axis is not centered. In case of e.g. an
        /// icon position of top-left no axis is centered.
        /// 
        /// </summary>
        public bool? Center
        {
            get
            {
                return _center;
            }
            set
            {
               _center = value;
            }
        }

        /// <summary>
        /// The gap between the icon and the text
        /// 
        /// </summary>
        public int Gap
        {
            get
            {
                return _gap;
            }
            set
            {
               _gap = value;
            }
        }

        /// <summary>
        /// The position of the icon in relation to the text
        /// 
        /// </summary>
        public qxDotNet.IconPositionEnum IconPosition
        {
            get
            {
                return _iconPosition;
            }
            set
            {
               _iconPosition = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Atom";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("center", _center, false);
            state.SetPropertyValue("gap", _gap, 4);
            state.SetPropertyValue("iconPosition", _iconPosition, IconPositionEnum.left);


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
