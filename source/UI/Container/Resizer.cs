using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Container
{
    /// <summary>
    /// The Resizer is a resizable container widget.
    /// 
    /// It allows to be resized (not moved), normally in
    /// the right and/or bottom directions. It is an alternative to splitters.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    ///  var resizer = new qx.ui.container.Resizer().set({
    ///  width: 200,
    ///  height: 100
    ///  });
    /// 
    ///  resizer.setLayout(new qx.ui.layout.Canvas());
    ///  var text = new qx.ui.form.TextArea("Resize me\
    /// I'm resizable");
    ///  resizer.add(text, {edge: 0});
    /// 
    ///  this.getRoot().add(resizer);
    /// 
    /// 
    /// This example creates a resizer, configures it with a canvas layout and
    /// adds a text area to it.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Resizer : qxDotNet.UI.Container.Composite
    {

        private bool? _resizableBottom = true;
        private bool? _resizableLeft = true;
        private bool? _resizableRight = true;
        private bool? _resizableTop = true;
        private int _resizeSensitivity = 5;
        private bool? _useResizeFrame = true;


        /// <summary>
        /// Whether the bottom edge is resizable
        /// 
        /// </summary>
        public bool? ResizableBottom
        {
            get
            {
                return _resizableBottom;
            }
            set
            {
               _resizableBottom = value;
            }
        }

        /// <summary>
        /// Whether the left edge is resizable
        /// 
        /// </summary>
        public bool? ResizableLeft
        {
            get
            {
                return _resizableLeft;
            }
            set
            {
               _resizableLeft = value;
            }
        }

        /// <summary>
        /// Whether the right edge is resizable
        /// 
        /// </summary>
        public bool? ResizableRight
        {
            get
            {
                return _resizableRight;
            }
            set
            {
               _resizableRight = value;
            }
        }

        /// <summary>
        /// Whether the top edge is resizable
        /// 
        /// </summary>
        public bool? ResizableTop
        {
            get
            {
                return _resizableTop;
            }
            set
            {
               _resizableTop = value;
            }
        }

        /// <summary>
        /// The tolerance to activate resizing
        /// 
        /// </summary>
        public int ResizeSensitivity
        {
            get
            {
                return _resizeSensitivity;
            }
            set
            {
               _resizeSensitivity = value;
            }
        }

        /// <summary>
        /// Whether a frame replacement should be used during the resize sequence
        /// 
        /// </summary>
        public bool? UseResizeFrame
        {
            get
            {
                return _useResizeFrame;
            }
            set
            {
               _useResizeFrame = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.container.Resizer";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("resizableBottom", _resizableBottom, true);
            state.SetPropertyValue("resizableLeft", _resizableLeft, true);
            state.SetPropertyValue("resizableRight", _resizableRight, true);
            state.SetPropertyValue("resizableTop", _resizableTop, true);
            state.SetPropertyValue("resizeSensitivity", _resizeSensitivity, 5);
            state.SetPropertyValue("useResizeFrame", _useResizeFrame, true);


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
