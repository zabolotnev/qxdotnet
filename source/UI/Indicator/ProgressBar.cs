using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Indicator
{
    /// <summary>
    /// The Progress bar is designed to simply display the current % complete
    /// for a process.
    /// 
    /// The Value is limited between 0 and Maximum value.
    /// It's not allowed to set a Maximum value of 0. If you set a Maximum value
    /// bigger than 0, but smaller than Value, it will be limited to Value.
    /// 
    /// The following example creates and adds a progress bar to the root element.
    /// A listener is used to show the user if the value is changed,
    /// and another one when the progress is complete.
    /// 
    /// 
    /// var pb = new qx.ui.indicator.ProgressBar();
    /// this.getRoot().add(pb, { left : 20, top: 20});
    /// 
    /// pb.addListener("change", function(e) {
    ///  this.debug(e.getData()); // % complete
    ///  this.debug(pb.getValue()); // absolute value
    /// });
    /// 
    /// pb.addListener("complete", function(e) {
    ///  this.debug("complete");
    /// });
    /// 
    /// //set a value
    /// pb.setValue(20);
    /// 
    /// </summary>
    public partial class ProgressBar : qxDotNet.UI.Container.Composite
    {

        private decimal _maximum = 0m;
        private decimal _value = 0m;


        /// <summary>
        /// Returns the maximum value of progress bar.
        /// 
        /// Sets the maximum value of the progress bar.
        /// 
        /// </summary>
        public decimal Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
               _maximum = value;
            }
        }

        /// <summary>
        /// Returns the progress bar value.
        /// 
        /// Sets the value of the progress bar.
        /// 
        /// </summary>
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
               _value = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.indicator.ProgressBar";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("maximum", _maximum, 0m);
            state.SetPropertyValue("value", _value, 0m);

            if (Change != null)
            {
                state.SetEvent("change", false);
            }
            if (Complete != null)
            {
                state.SetEvent("complete", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "change")
            {
                OnChange();
            }
            if (eventName == "complete")
            {
                OnComplete();
            }
        }

        /// <summary>
        /// Raises event 'Change'
        /// </summary>
        protected virtual void OnChange()
        {
            if (Change != null)
            {
                Change.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the % complete value is changed.
        /// 
        /// </summary>
        public event EventHandler Change;

        /// <summary>
        /// Raises event 'Complete'
        /// </summary>
        protected virtual void OnComplete()
        {
            if (Complete != null)
            {
                Complete.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the process is complete (value === maximum value)
        /// 
        /// </summary>
        public event EventHandler Complete;

    }
}
