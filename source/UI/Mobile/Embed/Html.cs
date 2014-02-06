using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Embed
{
    /// <summary>
    /// The Html widget embeds plain HTML code into the application  Example  Here is a little example of how to use the html widget.   var html = new qx.ui.mobile.embed.Html(); html.setHtml(\HelloWorld\); 
    /// </summary>
    public partial class Html : qxDotNet.UI.Mobile.Core.Widget
    {

        private string _html = null;


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


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.embed.Html";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("html", _html, null);


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
