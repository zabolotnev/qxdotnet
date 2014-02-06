using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data.Controller
{
    /// <summary>
    /// Form Controller  General idea  The form controller is responsible for connecting a form with a model. If no model is given, a model can be created. This created model will fit exactly to the given form and can be used for serialization. All the connections between the form items and the model are handled by an internal {@link qx.data.controller.Object}.  Features   Connect a form to a model (bidirectional) Create a model for a given form   Usage  The controller only works if both a controller and a model are set. Creating a model will automatically set the created model.  Cross reference   If you want to bind single values, use {@link qx.data.controller.Object} If you want to bind a list like widget, use {@link qx.data.controller.List} If you want to bind a tree widget, use {@link qx.data.controller.Tree} 
    /// </summary>
    public partial class Form : qxDotNet.Core.Object
    {

        private qxDotNet.Core.Object _model = null;
        private qxDotNet.UI.Form.Form _target = null;


        /// <summary>
        /// Data object containing the data which should be shown in the target.
        /// </summary>
        public qxDotNet.Core.Object Model
        {
            get
            {
                return _model;
            }
            set
            {
               _model = value;
               OnChangeModel();
            }
        }

        /// <summary>
        /// The target widget which should show the data.
        /// </summary>
        public qxDotNet.UI.Form.Form Target
        {
            get
            {
                return _target;
            }
            set
            {
               _target = value;
               OnChangeTarget();
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.data.controller.Form";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("model", _model, null);
            state.SetPropertyValue("target", _target, null);


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

        protected virtual void OnChangeTarget()
        {
            if (ChangeTarget != null)
            {
                ChangeTarget.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #target}.
        /// </summary>
        public event EventHandler ChangeTarget;

    }
}
