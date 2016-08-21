using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Application
{
    /// <summary>
    /// For a mobile application. Supports the mobile widget set.
    /// 
    /// </summary>
    public partial class Mobile : qxDotNet.Core.Object, qxDotNet.Application.IApplication
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.application.Mobile";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (Back != null)
            {
                state.SetEvent("back", false);
            }
            if (Popup != null)
            {
                state.SetEvent("popup", false);
            }
            if (Start != null)
            {
                state.SetEvent("start", false);
            }
            if (Stop != null)
            {
                state.SetEvent("stop", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "back")
            {
                OnBack();
            }
            if (eventName == "popup")
            {
                OnPopup();
            }
            if (eventName == "start")
            {
                OnStart();
            }
            if (eventName == "stop")
            {
                OnStop();
            }
        }

        /// <summary>
        /// Raises event 'Back'
        /// </summary>
        protected virtual void OnBack()
        {
            if (Back != null)
            {
                Back.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the method {@link qx.ui.mobile.page.Page#back} is called. It is possible to prevent
        /// the back event on {@link qx.ui.mobile.page.Page} by calling the
        /// {@link qx.event.type.Event#preventDefault}. Data indicating whether the action
        /// was triggered by a key event or not.
        /// 
        /// </summary>
        public event EventHandler Back;

        /// <summary>
        /// Raises event 'Popup'
        /// </summary>
        protected virtual void OnPopup()
        {
            if (Popup != null)
            {
                Popup.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when a {@link qx.ui.mobile.dialog.Popup popup} appears on screen.
        /// 
        /// </summary>
        public event EventHandler Popup;

        /// <summary>
        /// Raises event 'Start'
        /// </summary>
        protected virtual void OnStart()
        {
            if (Start != null)
            {
                Start.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the lifecycle method {@link #start} of any {@link qx.ui.mobile.page.Page page} is called
        /// 
        /// </summary>
        public event EventHandler Start;

        /// <summary>
        /// Raises event 'Stop'
        /// </summary>
        protected virtual void OnStop()
        {
            if (Stop != null)
            {
                Stop.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the lifecycle method {@link #stop} of any {@link qx.ui.mobile.page.Page page} is called
        /// 
        /// </summary>
        public event EventHandler Stop;

    }
}
