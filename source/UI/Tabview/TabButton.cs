using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Tabview
{
    /// <summary>
    /// A TabButton is the tapable part sitting on the {@link qx.ui.tabview.Page}.
    /// By tapping on the TabButton the user can set a Page active.
    /// 
    /// </summary>
    public partial class TabButton : qxDotNet.UI.Form.RadioButton, qxDotNet.UI.Form.IRadioItem
    {

        private bool? _showCloseButton = false;


        /// <summary>
        /// Indicates if the close button of a TabButton should be shown.
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.tabview.TabButton";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("showCloseButton", _showCloseButton, false);

            if (Close != null)
            {
                state.SetEvent("close", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "close")
            {
                OnClose();
            }
        }

        /// <summary>
        /// Raises event 'Close'
        /// </summary>
        protected virtual void OnClose()
        {
            if (Close != null)
            {
                Close.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired by {@link qx.ui.tabview.Page} if the close button is tapped.
        /// 
        /// Event data: The tab button.
        /// 
        /// </summary>
        public event EventHandler Close;

    }
}
