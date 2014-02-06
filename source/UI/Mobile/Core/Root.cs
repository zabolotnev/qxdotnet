using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.Core
{
    /// <summary>
    /// Root widget for the mobile application.
    /// </summary>
    public partial class Root : qxDotNet.UI.Mobile.Container.Composite
    {

        private bool? _showScrollbarY = true;
        private decimal _fontScale = 0m;


        /// <summary>
        /// Whether the native scrollbar should be shown or not.
        /// </summary>
        public bool? ShowScrollbarY
        {
            get
            {
                return _showScrollbarY;
            }
            set
            {
               _showScrollbarY = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal FontScale
        {
            get
            {
                return _fontScale;
            }
            set
            {
               _fontScale = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.ui.mobile.core.Root";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("showScrollbarY", _showScrollbarY, true);
            state.SetPropertyValue("fontScale", _fontScale, 0m);

            if (ChangeAppScale != null)
            {
                state.SetEvent("changeAppScale", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeAppScale")
            {
                OnChangeAppScale();
            }
        }

        protected virtual void OnChangeAppScale()
        {
            if (ChangeAppScale != null)
            {
                ChangeAppScale.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Event is fired when the app scale factor of the application has (or might have) changed.
        /// </summary>
        public event EventHandler ChangeAppScale;

    }
}
