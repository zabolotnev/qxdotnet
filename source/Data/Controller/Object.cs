using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data.Controller
{
    /// <summary>
    /// Object Controller  General idea  The idea of the object controller is to make the binding of one model object containing one or more properties as easy as possible. Therefore the controller can take a model as property. Every property in that model can be bound to one or more target properties. The binding will be for atomic types only like Numbers, Strings, ...  Features   Manages the bindings between the model properties and the different targets No need for the user to take care of the binding ids Can create an bidirectional binding (read- / write-binding) Handles the change of the model which means adding the old targets   Usage  The controller only can work if a model is set. If the model property is null, the controller is not working. But it can be null on any time.  Cross reference   If you want to bind a list like widget, use {@link qx.data.controller.List} If you want to bind a tree widget, use {@link qx.data.controller.Tree} If you want to bind a form widget, use {@link qx.data.controller.Form} 
    /// </summary>
    public partial class Object : qxDotNet.Core.Object
    {

        private qxDotNet.Core.Object _model = null;


        /// <summary>
        /// The model object which does have the properties for the binding.
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


        protected internal override string GetTypeName()
        {
            return "qx.data.controller.Object";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("model", _model, null);


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
