using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Event
{
    /// <summary>
    /// Global timer support.
    /// 
    /// This class can be used to periodically fire an event. This event can be
    /// used to simulate e.g. a background task. The static method
    /// {@link #once} is a special case. It will call a function deferred after a
    /// given timeout.
    /// 
    /// </summary>
    public partial class Timer : qxDotNet.Core.Object
    {

        private bool _enabled = true;
        private int _interval = 1000;


        /// <summary>
        /// With the enabled property the Timer can be started and suspended.
        /// Setting it to "true" is equivalent to {@link #start}, setting it
        /// to "false" is equivalent to {@link #stop}.
        /// 
        /// </summary>
        public bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
               _enabled = value;
            }
        }

        /// <summary>
        /// Time in milliseconds between two callback calls.
        /// This property can be set to modify the interval of
        /// a running timer.
        /// 
        /// </summary>
        public int Interval
        {
            get
            {
                return _interval;
            }
            set
            {
               _interval = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.event.Timer";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("enabled", _enabled, null);
            state.SetPropertyValue("interval", _interval, 1000);

            if (Interval != null)
            {
                state.SetEvent("interval", true);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "interval")
            {
                OnIntervalElapsed();
            }
        }

        /// <summary>
        /// Raises event 'Interval'
        /// </summary>
        protected virtual void OnIntervalElapsed()
        {
            if (IntervalElapsed != null)
            {
                IntervalElapsed.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event if fired each time the interval time has elapsed
        /// 
        /// </summary>
        public event EventHandler IntervalElapsed;

    }
}
