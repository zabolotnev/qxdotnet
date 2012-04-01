using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Toolbar
{
    /// <summary>
    /// Radio buttons are used to manage a single selection. Radio buttons only make sense used in a group of two or more of them. They are managed (connected) to a {@link qx.ui.form.RadioGroup} to handle the selection.
    /// </summary>
    public partial class RadioButton : qxDotNet.UI.Toolbar.CheckBox, qxDotNet.UI.Form.IModel, qxDotNet.UI.Form.IRadioItem
    {

//        private _var _model = null;


        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.toolbar.RadioButton";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeModel()
        {
            if (ChangeModel != null)
            {
                ChangeModel.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #model}.
        /// </summary>
        public event EventHandler ChangeModel;

    }
}
