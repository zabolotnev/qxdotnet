using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tabview
{
    /// <summary>
    /// A TabButton is the clickable part sitting on the {@link qx.ui.tabview.Page}. By clicking on the TabButton the user can set a Page active.
    /// </summary>
    public partial class TabButton : qxDotNet.UI.Form.RadioButton, qxDotNet.UI.Form.IRadioItem
    {

        private bool? _showCloseButton = false;


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

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tabview.TabButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("showCloseButton", _showCloseButton, false);

            state.SetEvent("close", false);

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
        /// Fired by {@link qx.ui.tabview.Page} if the close button is clicked.  Event data: The tab button.
        /// </summary>
        public event EventHandler Close;

    }
}
