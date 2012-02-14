using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Basic
{
    /// <summary>
    /// The label class brings typical text content to the widget system.  It supports simple text nodes and complex HTML (rich). The default content mode is for text only. The mode is changeable through the property {@link #rich}.  The label supports heightForWidth when used in HTML mode. This means that multi line HTML automatically computes the correct preferred height.  Example  Here is a little example of how to use the widget.    // a simple text label without wrapping and markup support  var label1 = new qx.ui.basic.Label(\Simpletextlabel\);  this.getRoot().add(label1, {left:20, top:10});   // a HTML label with automatic line wrapping  var label2 = new qx.ui.basic.Label().set({  value: \Alonglabeltextwithauto-wrapping.ThisalsomaycontainrichHTMLmarkup.\,  rich : true,  width: 120  });  this.getRoot().add(label2, {left:20, top:50});   The first label in this example is a basic text only label. As such no automatic wrapping is supported. The second label is a long label containing HTML markup with automatic line wrapping.  External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Label : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IStringForm
    {

        private qxDotNet.UI.Core.Widget _buddy = null;
        private bool? _rich = false;
        private qxDotNet.TextAlignEnum _textAlign = (TextAlignEnum)(-1);
        private string _value = "";
        private bool? _wrap = true;


        /// <summary>
        /// The buddy property can be used to connect the label to another widget. That causes two things:   The label will always take the same enabled state as the buddy  widget.    A click on the label will focus the buddy widget.    This is the behavior of the for attribute of HTML: http://www.w3.org/TR/html401/interact/forms.html#adef-for
        /// </summary>
        public qxDotNet.UI.Core.Widget Buddy
        {
            get
            {
                return _buddy;
            }
            set
            {
               _buddy = value;
            }
        }

        /// <summary>
        /// Switches between rich HTML and text content. The text mode (false) supports advanced features like ellipsis when the available space is not enough. HTML mode (true) supports multi-line content and all the markup features of HTML content.
        /// </summary>
        public bool? Rich
        {
            get
            {
                return _rich;
            }
            set
            {
               _rich = value;
               OnChangeRich();
            }
        }

        /// <summary>
        /// Control the text alignment
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
               OnChangeTextAlign();
            }
        }

        /// <summary>
        /// Contains the HTML or text content. Interpretation depends on the value of {@link #rich}. In text mode entities and other HTML special content is not supported. But it is possible to use unicode escape sequences to insert symbols and other non ASCII characters.
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
               _value = value;
               OnChangeValue();
            }
        }

        /// <summary>
        /// Controls whether text wrap is activated or not. But please note, that this property works only in combination with the property {@link #rich}. The {@link #wrap} has only an effect if the {@link #rich} property is set to true, otherwise {@link #wrap} has no effect.
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


        public override string GetTypeName()
        {
            return "qx.ui.basic.Label";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("buddy", _buddy, null);
            state.SetPropertyValue("rich", _rich, false);
            state.SetPropertyValue("textAlign", _textAlign, (TextAlignEnum)(-1));
            state.SetPropertyValue("value", _value, "");
            state.SetPropertyValue("wrap", _wrap, true);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeRich()
        {
            if (ChangeRich != null)
            {
                ChangeRich.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #rich}.
        /// </summary>
        public event EventHandler ChangeRich;

        protected virtual void OnChangeTextAlign()
        {
            if (ChangeTextAlign != null)
            {
                ChangeTextAlign.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #textAlign}.
        /// </summary>
        public event EventHandler ChangeTextAlign;

        protected virtual void OnChangeValue()
        {
            if (ChangeValue != null)
            {
                ChangeValue.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #value}.
        /// </summary>
        public event EventHandler ChangeValue;

    }
}
