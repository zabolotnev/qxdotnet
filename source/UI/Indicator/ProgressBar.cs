using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Indicator
{
    /// <summary>
    /// The Progress bar is designed to simply display the current % complete for a process.  The Value is limited between 0 and Maximum value. It";s not allowed to set a Maximum value of 0. If you set a Maximum value bigger than 0, but smaller than Value, it will be limited to Value.  The following example creates and adds a progress bar to the root element. A listener is used to show the user if the value is changed, and another one when the progress is complete.   var pb = new qx.ui.indicator.ProgressBar(); this.getRoot().add(pb, { left : 20, top: 20});  pb.addListener(\change\, function(e) {  this.debug(e.getData()); // % complete  this.debug(pb.getValue()); // absolute value });  pb.addListener(\complete\, function(e) {  this.debug(\complete\); });  //set a value pb.setValue(20); 
    /// </summary>
    public partial class ProgressBar : qxDotNet.UI.Container.Composite
    {

//        private _var _maximum = null;
//        private _var _value = null;


        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.indicator.ProgressBar";
        }

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

        protected virtual void OnChange()
        {
            if (Change != null)
            {
                Change.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the % complete value is changed.
        /// </summary>
        public event EventHandler Change;

        protected virtual void OnComplete()
        {
            if (Complete != null)
            {
                Complete.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the process is complete (value === maximum value)
        /// </summary>
        public event EventHandler Complete;

    }
}
