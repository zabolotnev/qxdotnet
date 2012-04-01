using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet
{
    public class Font : qxDotNet.Core.Object
    {

        private bool _bold;
        private string _color;
        private DecorationEnum _decoration;
        private bool _italic;
        private decimal _lineHeight;
        private int _size;

        public bool Bold
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

        public DecorationEnum Decoration
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

        public bool Italic
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

        protected internal override string GetTypeName()
        {
            return "qx.bom.Font";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("bold", _bold, false);
            state.SetPropertyValue("color", _color, null);
            state.SetPropertyValue("decoration", _decoration, DecorationEnum.@null);
            state.SetPropertyValue("italic", _italic, false);
            state.SetPropertyValue("lineHeight", _lineHeight, 0m);
            state.SetPropertyValue("size", _size, 0);
        }

        // font hack
        internal bool fontRenderPhase { get; set; }

    }
}
