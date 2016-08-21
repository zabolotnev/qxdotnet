using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// The form object is responsible for managing form items. For that, it takes
    /// advantage of two existing qooxdoo classes.
    /// The {@link qx.ui.form.Resetter} is used for resetting and the
    /// {@link qx.ui.form.validation.Manager} is used for all validation purposes.
    /// 
    /// The view code can be found in the used renderer ({@link qx.ui.form.renderer}).
    /// 
    /// </summary>
    public partial class Form : qxDotNet.Core.Object
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.form.Form";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (Change != null)
            {
                state.SetEvent("change", false);
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
        /// Fired as soon as something changes in the form.
        /// 
        /// </summary>
        public event EventHandler Change;

    }
}
