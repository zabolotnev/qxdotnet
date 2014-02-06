using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Bom
{
    /// <summary>
    /// A wrapper for CSS font styles. Fond objects can be applied to instances of {@link qx.html.Element}.
    /// </summary>
    public partial class Font : qxDotNet.Core.Object
    {

        private bool? _bold = false;
        private string _color = null;
        private qxDotNet.DecorationEnum _decoration = (DecorationEnum)(-1);
//        private _array _family = null;
        private bool? _italic = false;
        private decimal _lineHeight = 0m;
        private int _size = 0;
        private string _textShadow = "";


        /// <summary>
        /// Whether the font is bold
        /// </summary>
        public bool? Bold
        {
            get
            {
                return _bold;
            }
            set
            {
               _bold = value;
            }
        }

        /// <summary>
        /// The text color for this font
        /// </summary>
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
               _color = value;
            }
        }

        /// <summary>
        /// The text decoration for this font
        /// </summary>
        public qxDotNet.DecorationEnum Decoration
        {
            get
            {
                return _decoration;
            }
            set
            {
               _decoration = value;
            }
        }

        /// <summary>
        /// Whether the font is italic
        /// </summary>
        public bool? Italic
        {
            get
            {
                return _italic;
            }
            set
            {
               _italic = value;
            }
        }

        /// <summary>
        /// The line height as scaling factor of the default line height. A value of 1 corresponds to the default line height
        /// </summary>
        public decimal LineHeight
        {
            get
            {
                return _lineHeight;
            }
            set
            {
               _lineHeight = value;
            }
        }

        /// <summary>
        /// The font size (Unit: pixel)
        /// </summary>
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
               _size = value;
            }
        }

        /// <summary>
        /// The text shadow for this font
        /// </summary>
        public string TextShadow
        {
            get
            {
                return _textShadow;
            }
            set
            {
               _textShadow = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.bom.Font";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("bold", _bold, false);
            state.SetPropertyValue("color", _color, null);
            state.SetPropertyValue("decoration", _decoration, (DecorationEnum)(-1));
            state.SetPropertyValue("italic", _italic, false);
            state.SetPropertyValue("lineHeight", _lineHeight, 0m);
            state.SetPropertyValue("size", _size, 0);
            state.SetPropertyValue("textShadow", _textShadow, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
