using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The TextField is a multi-line text input field.
    /// </summary>
    public partial class TextArea : qxDotNet.UI.Form.AbstractField
    {

        private bool? _autoSize = false;
        private int _minimalLineHeight = 4;
        private int _singleStep = 20;
        private bool? _wrap = true;


        /// <summary>
        /// Whether the TextArea should automatically adjust to the height of the content.  To set the initial height, modify {@link #minHeight}. If you wish to set a minHeight below four lines of text, also set {@link #minimalLineHeight}. In order to limit growing to a certain height, set {@link #maxHeight} respectively. Please note that autoSize is ignored when the {@link #height} property is in use.
        /// </summary>
        public bool? AutoSize
        {
            get
            {
                return _autoSize;
            }
            set
            {
               _autoSize = value;
            }
        }

        /// <summary>
        /// Minimal line height. On default this is set to four lines.
        /// </summary>
        public int MinimalLineHeight
        {
            get
            {
                return _minimalLineHeight;
            }
            set
            {
               _minimalLineHeight = value;
            }
        }

        /// <summary>
        /// Factor for scrolling the TextArea with the mouse wheel.
        /// </summary>
        public int SingleStep
        {
            get
            {
                return _singleStep;
            }
            set
            {
               _singleStep = value;
            }
        }

        /// <summary>
        /// Controls whether text wrap is activated or not.
        /// </summary>
        public bool? Wrap
        {
            get
            {
                return _wrap;
            }
            set
            {
               _wrap = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.TextArea";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("autoSize", _autoSize, false);
            state.SetPropertyValue("minimalLineHeight", _minimalLineHeight, 4);
            state.SetPropertyValue("singleStep", _singleStep, 20);
            state.SetPropertyValue("wrap", _wrap, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
