using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// A basic layout, which supports positioning of child widgets in a 'flowing'
    /// manner, starting at the container's top/left position, placing children left to right
    /// (like a HBox) until the there's no remaining room for the next child. When
    /// out of room on the current line of elements, a new line is started, cleared
    /// below the tallest child of the preceding line&#8212;a bit like using 'float'
    /// in CSS, except that a new line wraps all the way back to the left.
    /// 
    /// Features
    /// 
    /// 
    ///  Reversing children order 
    ///  Manual line breaks 
    ///  Horizontal alignment of lines 
    ///  Vertical alignment of individual widgets within a line 
    ///  Margins with horizontal margin collapsing 
    ///  Horizontal and vertical spacing 
    ///  Height for width calculations 
    ///  Auto-sizing 
    /// 
    /// 
    /// Item Properties
    /// 
    /// 
    /// lineBreak (Boolean): If set to true
    ///  a forced line break will happen after this child widget.
    /// 
    /// stretch (Boolean): If set to true
    ///  the widget will be stretched to the remaining line width. This requires
    ///  lineBreak to be true.
    /// 
    /// 
    /// 
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the Flow layout.
    /// 
    /// 
    ///  var flowlayout = new qx.ui.layout.Flow();
    /// 
    ///  flowlayout.setAlignX( "center" ); // Align children to the X axis of the container (left|center|right)
    /// 
    ///  var container = new qx.ui.container.Composite(flowlayout);
    ///  this.getRoot().add(container, {edge: 0});
    /// 
    ///  var button1 = new qx.ui.form.Button("1. First Button", "flowlayout/test.png");
    ///  container.add(button1);
    /// 
    ///  var button2 = new qx.ui.form.Button("2. Second longer Button...", "flowlayout/test.png");
    ///  // Have this child create a break in the current Line (next child will always start a new Line)
    ///  container.add(button2, {lineBreak: true});
    /// 
    ///  var button3 = new qx.ui.form.Button("3rd really, really, really long Button", "flowlayout/test.png");
    ///  button3.setHeight(100); // tall button
    ///  container.add(button3);
    /// 
    ///  var button4 = new qx.ui.form.Button("Number 4", "flowlayout/test.png");
    ///  button4.setAlignY("bottom");
    ///  container.add(button4);
    /// 
    ///  var button5 = new qx.ui.form.Button("20px Margins around the great big 5th button!");
    ///  button5.setHeight(100); // tall button
    ///  button5.setMargin(20);
    ///  container.add(button5, {lineBreak: true}); // Line break after this button.
    /// 
    ///  var button6 = new qx.ui.form.Button("Number 6", "flowlayout/test.png");
    ///  button6.setAlignY("middle"); // Align this child to the vertical center of this line.
    ///  container.add(button6);
    /// 
    ///  var button7 = new qx.ui.form.Button("7th a wide, short button", "flowlayout/test.png");
    ///  button7.setMaxHeight(20); // short button
    ///  container.add(button7);
    /// 
    /// 
    /// External Documentation
    /// 
    /// 
    /// Extended documentation and links to demos of this layout in the qooxdoo manual.
    /// </summary>
    public partial class Flow : qxDotNet.UI.Layout.Abstract
    {

        private qxDotNet.AlignXEnum _alignX = AlignXEnum.left;
        private qxDotNet.AlignYEnum _alignY = AlignYEnum.top;
        private bool? _reversed = false;
        private int _spacingX = 0;
        private int _spacingY = 0;


        /// <summary>
        /// Horizontal alignment of the whole children block. The horizontal
        /// alignment of the child is completely ignored in HBoxes (
        /// {@link qx.ui.core.LayoutItem#alignX}).
        /// 
        /// </summary>
        public qxDotNet.AlignXEnum AlignX
        {
            get
            {
                return _alignX;
            }
            set
            {
               _alignX = value;
            }
        }

        /// <summary>
        /// Vertical alignment of each child. Can be overridden through
        /// {@link qx.ui.core.LayoutItem#alignY}.
        /// 
        /// </summary>
        public qxDotNet.AlignYEnum AlignY
        {
            get
            {
                return _alignY;
            }
            set
            {
               _alignY = value;
            }
        }

        /// <summary>
        /// Whether the actual children list should be laid out in reversed order.
        /// 
        /// </summary>
        public bool? Reversed
        {
            get
            {
                return _reversed;
            }
            set
            {
               _reversed = value;
            }
        }

        /// <summary>
        /// Horizontal spacing between two children
        /// 
        /// </summary>
        public int SpacingX
        {
            get
            {
                return _spacingX;
            }
            set
            {
               _spacingX = value;
            }
        }

        /// <summary>
        /// The vertical spacing between the lines.
        /// 
        /// </summary>
        public int SpacingY
        {
            get
            {
                return _spacingY;
            }
            set
            {
               _spacingY = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.layout.Flow";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("alignX", _alignX, AlignXEnum.left);
            state.SetPropertyValue("alignY", _alignY, AlignYEnum.top);
            state.SetPropertyValue("reversed", _reversed, false);
            state.SetPropertyValue("spacingX", _spacingX, 0);
            state.SetPropertyValue("spacingY", _spacingY, 0);


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
