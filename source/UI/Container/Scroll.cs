using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Container
{
    /// <summary>
    /// Container, which allows vertical and horizontal scrolling if the contents is larger than the container.  Note that this class can only have one child widget. This container has a fixed layout, which cannot be changed.  Example  Here is a little example of how to use the widget.    // create scroll container  var scroll = new qx.ui.container.Scroll().set({  width: 300,  height: 200  });   // add a widget which is larger than the container  scroll.add(new qx.ui.core.Widget().set({  width: 600,  minWidth: 600,  height: 400,  minHeight: 400  });   this.getRoot().add(scroll);   This example creates a scroll container and adds a widget, which is larger than the container. This will cause the container to display vertical and horizontal toolbars.  External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Scroll : qxDotNet.UI.Core.Scroll.AbstractScrollArea
    {

        private int _contentPaddingBottom = 0;
        private int _contentPaddingLeft = 0;
        private int _contentPaddingRight = 0;
        private int _contentPaddingTop = 0;


        /// <summary>
        /// Bottom padding of the content pane
        /// </summary>
        public int ContentPaddingBottom
        {
            get
            {
                return _contentPaddingBottom;
            }
            set
            {
               _contentPaddingBottom = value;
            }
        }

        /// <summary>
        /// Left padding of the content pane
        /// </summary>
        public int ContentPaddingLeft
        {
            get
            {
                return _contentPaddingLeft;
            }
            set
            {
               _contentPaddingLeft = value;
            }
        }

        /// <summary>
        /// Right padding of the content pane
        /// </summary>
        public int ContentPaddingRight
        {
            get
            {
                return _contentPaddingRight;
            }
            set
            {
               _contentPaddingRight = value;
            }
        }

        /// <summary>
        /// Top padding of the content pane
        /// </summary>
        public int ContentPaddingTop
        {
            get
            {
                return _contentPaddingTop;
            }
            set
            {
               _contentPaddingTop = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.container.Scroll";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("contentPaddingBottom", _contentPaddingBottom, 0);
            state.SetPropertyValue("contentPaddingLeft", _contentPaddingLeft, 0);
            state.SetPropertyValue("contentPaddingRight", _contentPaddingRight, 0);
            state.SetPropertyValue("contentPaddingTop", _contentPaddingTop, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
