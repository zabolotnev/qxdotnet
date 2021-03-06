﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The HoverButton is an {@link qx.ui.basic.Atom}, which fires repeatedly
    /// execute events while the pointer is over the widget.
    /// 
    /// The rate at which the execute event is fired accelerates is the pointer keeps
    /// inside of the widget. The initial delay and the interval time can be set using
    /// the properties {@link #firstInterval} and {@link #interval}. The
    /// {@link #execute} events will be fired in a shorter amount of time if the pointer
    /// remains over the widget, until the min {@link #minTimer} is reached.
    /// The {@link #timerDecrease} property sets the amount of milliseconds which will
    /// decreased after every firing.
    /// 
    /// Example
    /// 
    /// Here is a little example of how to use the widget.
    /// 
    /// 
    ///  var button = new qx.ui.form.HoverButton("Hello World");
    /// 
    ///  button.addListener("execute", function(e) {
    ///  alert("Button is hovered");
    ///  }, this);
    /// 
    ///  this.getRoot.add(button);
    /// 
    /// 
    /// This example creates a button with the label "Hello World" and attaches an
    /// event listener to the {@link #execute} event.
    /// 
    /// External Documentation
    /// 
    /// 
    /// Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class HoverButton : qxDotNet.UI.Basic.Atom, qxDotNet.UI.Form.IExecutable
    {

        private int _firstInterval = 200;
        private int _interval = 80;
        private int _minTimer = 20;
        private int _timerDecrease = 2;
        private qxDotNet.UI.Command.Command _command = null;


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
        public int MinTimer
        {
            get
            {
                return _minTimer;
            }
            set
            {
               _minTimer = value;
            }
        }

        /// <summary>
        /// Decrease of the timer on each interval (for the next interval) until minTimer reached.
        /// 
        /// </summary>
        public int TimerDecrease
        {
            get
            {
                return _timerDecrease;
            }
            set
            {
               _timerDecrease = value;
            }
        }

        /// <summary>
        /// A command called if the {@link #execute} method is called, e.g. on a
        /// button tap.
        /// 
        /// </summary>
        public qxDotNet.UI.Command.Command Command
        {
            get
            {
                return _command;
            }
            set
            {
               _command = value;
               OnChangeCommand();
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.HoverButton";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("firstInterval", _firstInterval, 200);
            state.SetPropertyValue("interval", _interval, 80);
            state.SetPropertyValue("minTimer", _minTimer, 20);
            state.SetPropertyValue("timerDecrease", _timerDecrease, 2);
            state.SetPropertyValue("command", _command, null);

            if (Execute != null)
            {
                state.SetEvent("execute", true);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "execute")
            {
                OnExecute();
            }
        }

        /// <summary>
        /// Raises event 'ChangeCommand'
        /// </summary>
        protected virtual void OnChangeCommand()
        {
            if (ChangeCommand != null)
            {
                ChangeCommand.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #command}.
        /// </summary>
        public event EventHandler ChangeCommand;

        /// <summary>
        /// Raises event 'Execute'
        /// </summary>
        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the {@link #execute} method is invoked.
        /// 
        /// </summary>
        public event EventHandler Execute;

    }
}
