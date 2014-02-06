using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Tabbar
{
    /// <summary>
    /// A tab button widget.  A tab button can be added to the tab bar and is associated with a {@link #view}.
    /// </summary>
    public partial class TabButton : qxDotNet.UI.Mobile.Form.Button
    {

        private qxDotNet.UI.Mobile.Core.Widget _view = null;


        /// <summary>
        /// The associated view.
        /// </summary>
        public qxDotNet.UI.Mobile.Core.Widget View
        {
            get
            {
                return _view;
            }
            set
            {
               _view = value;
               OnChangeView();
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.tabbar.TabButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("view", _view, null);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeView()
        {
            if (ChangeView != null)
            {
                ChangeView.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #view}.
        /// </summary>
        public event EventHandler ChangeView;

    }
}
