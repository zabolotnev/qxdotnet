using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.List.Renderer
{
    /// <summary>
    /// Base class for all list item renderer.
    /// </summary>
    public abstract partial class Abstract : qxDotNet.UI.Mobile.Container.Composite
    {

        private bool? _selectable = true;
        private bool? _selected = false;
        private bool? _showArrow = false;


        /// <summary>
        /// Whether the row is selectable.
        /// </summary>
        public bool? Selectable
        {
            get
            {
                return _selectable;
            }
            set
            {
               _selectable = value;
            }
        }

        /// <summary>
        /// Whether the row is selected.
        /// </summary>
        public bool? Selected
        {
            get
            {
                return _selected;
            }
            set
            {
               _selected = value;
            }
        }

        /// <summary>
        /// Whether to show an arrow in the row.
        /// </summary>
        public bool? ShowArrow
        {
            get
            {
                return _showArrow;
            }
            set
            {
               _showArrow = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.list.renderer.Abstract";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("selectable", _selectable, true);
            state.SetPropertyValue("selected", _selected, false);
            state.SetPropertyValue("showArrow", _showArrow, false);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
