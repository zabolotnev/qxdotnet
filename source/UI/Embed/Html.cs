using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Embed
{
    /// <summary>
    /// The Html widget embeds plain HTML code into the application  Example  Here is a little example of how to use the canvas widget.   var html = new qx.ui.embed.Html(); html.setHtml(\HelloWorld\);   External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class Html : qxDotNet.UI.Core.Widget
    {

        private string _cssClass = "";
        private string _html = "";
        private qxDotNet.OverflowEnum _overflowX = (OverflowEnum)(-1);
        private qxDotNet.OverflowEnum _overflowY = (OverflowEnum)(-1);


        /// <summary>
        /// The css classname for the html embed. IMPORTANT Paddings and borders does not work in the css class. These styles cause conflicts with the layout engine.
        /// </summary>
        public string CssClass
        {
            get
            {
                return _cssClass;
            }
            set
            {
               _cssClass = value;
            }
        }

        /// <summary>
        /// Any text string which can contain HTML, too
        /// </summary>
        public string HtmlText
        {
            get
            {
                return _html;
            }
            set
            {
               _html = value;
               OnChangeHtml();
            }
        }

        /// <summary>
        /// Whether the widget should have horizontal scrollbars.
        /// </summary>
        public qxDotNet.OverflowEnum OverflowX
        {
            get
            {
                return _overflowX;
            }
            set
            {
               _overflowX = value;
            }
        }

        /// <summary>
        /// Whether the widget should have vertical scrollbars.
        /// </summary>
        public qxDotNet.OverflowEnum OverflowY
        {
            get
            {
                return _overflowY;
            }
            set
            {
               _overflowY = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.embed.Html";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("cssClass", _cssClass, "");
            state.SetPropertyValue("html", _html, "");
            state.SetPropertyValue("overflowX", _overflowX, (OverflowEnum)(-1));
            state.SetPropertyValue("overflowY", _overflowY, (OverflowEnum)(-1));


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeHtml()
        {
            if (ChangeHtml != null)
            {
                ChangeHtml.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #html}.
        /// </summary>
        public event EventHandler ChangeHtml;

    }
}
