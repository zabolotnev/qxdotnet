using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tabview
{
    /// <summary>
    /// A page is the way to add content to a {@link TabView}. Each page gets a button to switch to the page. Only one page is visible at a time.
    /// </summary>
    public partial class Page : qxDotNet.UI.Container.Composite
    {

        private string _icon = "";
        private string _label = "";
        private bool? _showCloseButton = false;


        /// <summary>
        /// Any URI String supported by qx.ui.basic.Image to display an icon in Page&#8217;s button.
        /// </summary>
        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
               _icon = value;
            }
        }

        /// <summary>
        /// The label/caption/text of the Page&#8217;s button.
        /// </summary>
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
               _label = value;
            }
        }

        /// <summary>
        /// Indicates if the close button of a TabButton should be shown.
        /// </summary>
        public bool? ShowCloseButton
        {
            get
            {
                return _showCloseButton;
            }
            set
            {
               _showCloseButton = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.tabview.Page";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("icon", _icon, "");
            state.SetPropertyValue("label", _label, "");
            state.SetPropertyValue("showCloseButton", _showCloseButton, false);

            if (Close != null)
            {
                state.SetEvent("close", false);
            }

            state.SetEvent("close", true);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "close")
            {
                OnClose();
            }
        }

        protected virtual void OnClose()
        {
            if (Close != null)
            {
                Close.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired by {@link qx.ui.tabview.TabButton} if the close button is clicked.
        /// </summary>
        public event EventHandler Close;

    }
}
