using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Layout
{
    /// <summary>
    /// A basic layout, which supports positioning of child widgets in a &#8216;flowing&#8217; manner, starting at the container&#8217;s top/left position, placing children left to right (like a HBox) until the there&#8217;s no remaining room for the next child. When out of room on the current line of elements, a new line is started, cleared below the tallest child of the preceding line&#8212;a bit like using &#8216;float&#8217; in CSS, except that a new line wraps all the way back to the left.  Features    Reversing children order   Manual line breaks   Horizontal alignment of lines   Vertical alignment of individual widgets within a line   Margins with horizontal margin collapsing   Horizontal and vertical spacing   Height for width calculations   Auto-sizing    Item Properties   lineBreak (Boolean): If set to true  a forced line break will happen after this child widget.    Example  Here is a little example of how to use the Flow layout.    var flowlayout = new qx.ui.layout.Flow();   flowlayout.setAlignX( \center\ ); // Align children to the X axis of the container (left|center|right)   var container = new qx.ui.container.Composite(flowlayout);  this.getRoot().add(container, {edge: 0});   var button1 = new qx.ui.form.Button(\1.FirstButton\, \flowlayout/test.png\);  container.add(button1);   var button2 = new qx.ui.form.Button(\2.SecondlongerButton...\, \flowlayout/test.png\);  // Have this child create a break in the current Line (next child will always start a new Line)  container.add(button2, {lineBreak: true});   var button3 = new qx.ui.form.Button(\3rdreally
    /// </summary>
    public partial class Flow : qxDotNet.UI.Layout.Abstract
    {

        private qxDotNet.AlignXEnum _alignX = AlignXEnum.left;
        private qxDotNet.AlignYEnum _alignY = AlignYEnum.top;
        private bool? _reversed = false;
        private int _spacingX = 0;
        private int _spacingY = 0;


        /// <summary>
        /// Horizontal alignment of the whole children block. The horizontal alignment of the child is completely ignored in HBoxes ( {@link qx.ui.core.LayoutItem#alignX}).
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
        /// Vertical alignment of each child. Can be overridden through {@link qx.ui.core.LayoutItem#alignY}.
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


        public override string GetTypeName()
        {
            return "qx.ui.layout.Flow";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("alignX", _alignX, AlignXEnum.left);
            state.SetPropertyValue("alignY", _alignY, AlignYEnum.top);
            state.SetPropertyValue("reversed", _reversed, false);
            state.SetPropertyValue("spacingX", _spacingX, 0);
            state.SetPropertyValue("spacingY", _spacingY, 0);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
