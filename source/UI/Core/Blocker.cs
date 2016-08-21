using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{
    /// <summary>
    /// This class blocks events and can be included into all widgets.
    /// 
    /// The {@link #block} and {@link #unblock} methods provided by this class can be used
    /// to block any event from the widget. When blocked,
    /// the blocker widget overlays the widget to block, including the padding area.
    /// 
    /// </summary>
    public partial class Blocker : qxDotNet.Core.Object
    {

        private string _color = null;
        private bool? _keepBlockerActive = false;
        private decimal _opacity = 1m;


        /// <summary>
        /// Color of the blocker
        /// 
        /// </summary>
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
               _color = value;
            }
        }

        /// <summary>
        /// If this property is enabled, the blocker created with {@link #block}
        /// will always stay activated. This means that the blocker then gets all keyboard
        /// events, this is useful to block keyboard input on other widgets.
        /// Take care that only one blocker instance will be kept active, otherwise your
        /// browser will freeze.
        /// 
        /// </summary>
        public bool? KeepBlockerActive
        {
            get
            {
                return _keepBlockerActive;
            }
            set
            {
               _keepBlockerActive = value;
            }
        }

        /// <summary>
        /// Opacity of the blocker
        /// 
        /// </summary>
        public decimal Opacity
        {
            get
            {
                return _opacity;
            }
            set
            {
               _opacity = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.core.Blocker";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("color", _color, null);
            state.SetPropertyValue("keepBlockerActive", _keepBlockerActive, false);
            state.SetPropertyValue("opacity", _opacity, 1m);

            if (Blocked != null)
            {
                state.SetEvent("blocked", false);
            }
            if (Unblocked != null)
            {
                state.SetEvent("unblocked", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "blocked")
            {
                OnBlocked();
            }
            if (eventName == "unblocked")
            {
                OnUnblocked();
            }
        }

        /// <summary>
        /// Raises event 'Blocked'
        /// </summary>
        protected virtual void OnBlocked()
        {
            if (Blocked != null)
            {
                Blocked.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fires after {@link #block} executed.
        /// 
        /// </summary>
        public event EventHandler Blocked;

        /// <summary>
        /// Raises event 'Unblocked'
        /// </summary>
        protected virtual void OnUnblocked()
        {
            if (Unblocked != null)
            {
                Unblocked.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fires after {@link #unblock} executed.
        /// 
        /// </summary>
        public event EventHandler Unblocked;

    }
}
