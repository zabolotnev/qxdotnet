using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Cell
{
    /// <summary>
    /// EXPERIMENTAL!  Themeable Cell renderer.  This cell renderer can be styled by an appearance theme.
    /// </summary>
    public partial class Cell : qxDotNet.UI.Virtual.Cell.Abstract
    {

        private string _appearance = "cell";
        private string _backgroundColor = null;
        private Font _font = null;
        private int _paddingBottom = 0;
        private int _paddingLeft = 0;
        private int _paddingRight = 0;
        private int _paddingTop = 0;
        private qxDotNet.TextAlignEnum _textAlign = (TextAlignEnum)(-1);
        private string _textColor = null;


        /// <summary>
        /// The appearance ID. This ID is used to identify the appearance theme entry to use for this cell.
        /// </summary>
        public string Appearance
        {
            get
            {
                return _appearance;
            }
            set
            {
               _appearance = value;
            }
        }

        /// <summary>
        /// The cell";s background color
        /// </summary>
        public string BackgroundColor
        {
            get
            {
                return _backgroundColor;
            }
            set
            {
               _backgroundColor = value;
            }
        }

        /// <summary>
        /// The cell";s font. The value is either a font name defined in the font theme or an instance of {@link qx.bom.Font}.
        /// </summary>
        public Font Font
        {
            get
            {
                return _font;
            }
            set
            {
               _font = value;
            }
        }

        /// <summary>
        /// Padding of the widget (bottom)
        /// </summary>
        public int PaddingBottom
        {
            get
            {
                return _paddingBottom;
            }
            set
            {
               _paddingBottom = value;
            }
        }

        /// <summary>
        /// Padding of the widget (left)
        /// </summary>
        public int PaddingLeft
        {
            get
            {
                return _paddingLeft;
            }
            set
            {
               _paddingLeft = value;
            }
        }

        /// <summary>
        /// Padding of the widget (right)
        /// </summary>
        public int PaddingRight
        {
            get
            {
                return _paddingRight;
            }
            set
            {
               _paddingRight = value;
            }
        }

        /// <summary>
        /// Padding of the widget (top)
        /// </summary>
        public int PaddingTop
        {
            get
            {
                return _paddingTop;
            }
            set
            {
               _paddingTop = value;
            }
        }

        /// <summary>
        /// The text alignment of the cell";s content
        /// </summary>
        public qxDotNet.TextAlignEnum TextAlign
        {
            get
            {
                return _textAlign;
            }
            set
            {
               _textAlign = value;
            }
        }

        /// <summary>
        /// The cell";s text color
        /// </summary>
        public string TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
               _textColor = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.virtual.cell.Cell";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("appearance", _appearance, "cell");
            state.SetPropertyValue("backgroundColor", _backgroundColor, null);
            state.SetPropertyValue("font", _font, null);
            state.SetPropertyValue("paddingBottom", _paddingBottom, 0);
            state.SetPropertyValue("paddingLeft", _paddingLeft, 0);
            state.SetPropertyValue("paddingRight", _paddingRight, 0);
            state.SetPropertyValue("paddingTop", _paddingTop, 0);
            state.SetPropertyValue("textAlign", _textAlign, (TextAlignEnum)(-1));
            state.SetPropertyValue("textColor", _textColor, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
