using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Event
{
    /// <summary>
    /// Timer, which accelerates after each interval. The initial delay and the
    /// interval time can be set using the properties {@link #firstInterval}
    /// and {@link #interval}. The {@link #interval} events will be fired with
    /// decreasing interval times while the timer is running, until the {@link #minimum}
    /// is reached. The {@link #decrease} property sets the amount of milliseconds
    /// which will decreased after every firing.
    /// 
    /// This class is e.g. used in the {@link qx.ui.form.RepeatButton} and
    /// {@link qx.ui.form.HoverButton} widgets.
    /// 
    /// </summary>
    public partial class AcceleratingTimer : qxDotNet.Core.Object
    {

        private int _decrease = 2;
        private int _firstInterval = 500;
        private int _interval = 100;
        private int _minimum = 20;


        /// <summary>
        /// Decrease of the timer on each interval (for the next interval) until minTimer reached.
        /// 
        /// </summary>
        public int Decrease
        {
            get
            {
                return _decrease;
            }
            set
            {
               _decrease = value;
            }
        }

        /// <summary>
        /// Interval used for the first run of the timer. Usually a greater value
        /// than the "interval" property value to a little delayed reaction at the first
        /// time.
        /// 
        /// </summary>
        public int FirstInterval
        {
            get
            {
                return _firstInterval;
            }
            set
            {
               _firstInterval = value;
            }
        }

        /// <summary>
        /// Interval used after the first run of the timer. Usually a smaller value
        /// than the "firstInterval" property value to get a faster reaction.
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
        /// This configures the minimum value for the timer interval.
        /// 
        /// </summary>
        public int Minimum
        {
            get
            {
                return _minimum;
            }
            set
            {
               _minimum = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.event.AcceleratingTimer";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("decrease", _decrease, 2);
            state.SetPropertyValue("firstInterval", _firstInterval, 500);
            state.SetPropertyValue("interval", _interval, 100);
            state.SetPropertyValue("minimum", _minimum, 20);

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
