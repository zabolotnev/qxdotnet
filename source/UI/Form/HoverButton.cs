using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The HoverButton is an {@link qx.ui.basic.Atom}, which fires repeatedly execute events while the mouse is over the widget.  The rate at which the execute event is fired accelerates is the mouse keeps inside of the widget. The initial delay and the interval time can be set using the properties {@link #firstInterval} and {@link #interval}. The {@link #execute} events will be fired in a shorter amount of time if the mouse remains over the widget, until the min {@link #minTimer} is reached. The {@link #timerDecrease} property sets the amount of milliseconds which will decreased after every firing.  Example  Here is a little example of how to use the widget.    var button = new qx.ui.form.HoverButton(\HelloWorld\);   button.addListener(\execute\, function(e) {  alert(\Buttonishovered\);  }, this);   this.getRoot.add(button);   This example creates a button with the label &#8220;Hello World&#8221; and attaches an event listener to the {@link #execute} event.  External Documentation   Documentation of this widget in the qooxdoo manual.
    /// </summary>
    public partial class HoverButton : qxDotNet.UI.Basic.Atom, qxDotNet.UI.Form.IExecutable
    {

        private int _firstInterval = 200;
        private int _interval = 80;
        private int _minTimer = 20;
        private int _timerDecrease = 2;
        private qxDotNet.UI.Core.Command _command = null;


        /// <summary>
        /// Interval used for the first run of the timer. Usually a greater value than the &#8220;interval&#8221; property value to a little delayed reaction at the first time.
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
        /// Interval used after the first run of the timer. Usually a smaller value than the &#8220;firstInterval&#8221; property value to get a faster reaction.
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
        /// A command called if the {@link #execute} method is called, e.g. on a button click.
        /// </summary>
        public qxDotNet.UI.Core.Command Command
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
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.HoverButton";
        }

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
                state.SetEvent("execute", false);
            }

            state.SetEvent("execute", true);

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "execute")
            {
                OnExecute();
            }
        }

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

        protected virtual void OnExecute()
        {
            if (Execute != null)
            {
                Execute.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired if the {@link #execute} method is invoked.
        /// </summary>
        public event EventHandler Execute;

    }
}
