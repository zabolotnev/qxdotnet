using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data.Controller
{
    /// <summary>
    /// Tree Controller
    /// 
    /// General idea
    /// 
    /// The tree controller is the controller made for the {@link qx.ui.tree.Tree}
    /// widget in qooxdoo. Therefore, it is responsible for creating and adding the
    /// tree folders to the tree given as target.
    /// 
    /// Features
    /// 
    /// 
    /// Synchronize the model and the target
    /// Label and icon are bindable
    /// Takes care of the selection
    /// Passes on the options used by {@link qx.data.SingleValueBinding#bind}
    /// 
    /// 
    /// Usage
    /// 
    /// As model, you can use every qooxdoo widget structure having one property,
    /// which is a data array holding the children of the current node. There can
    /// be as many additional as you like.
    /// You need to specify a model, a target, a child path and a label path to
    /// make the controller work.
    /// 
    /// Cross reference
    /// 
    /// 
    /// If you want to bind single values, use {@link qx.data.controller.Object}
    /// If you want to bind a list like widget, use {@link qx.data.controller.List}
    /// If you want to bin a form widget, use {@link qx.data.controller.Form}
    /// 
    /// </summary>
    public partial class Tree : qxDotNet.Core.Object
    {

        private string _childPath = "";
//TODO: private _var _delegate = null;
//TODO: private _var _iconOptions = null;
        private string _iconPath = "";
//TODO: private _var _labelOptions = null;
        private string _labelPath = "";
        private qxDotNet.Core.Object _model = null;
//TODO: private _var _target = null;


        /// <summary>
        /// The name of the property, where the children are stored in the model.
        /// 
        /// </summary>
        public string ChildPath
        {
            get
            {
                return _childPath;
            }
            set
            {
               _childPath = value;
            }
        }

        /// <summary>
        /// The name of the property, where the source for the tree folders icon
        /// is stored in the model classes.
        /// 
        /// </summary>
        public string IconPath
        {
            get
            {
                return _iconPath;
            }
            set
            {
               _iconPath = value;
            }
        }

        /// <summary>
        /// The name of the property, where the value for the tree folders label
        /// is stored in the model classes.
        /// 
        /// </summary>
        public string LabelPath
        {
            get
            {
                return _labelPath;
            }
            set
            {
               _labelPath = value;
            }
        }

        /// <summary>
        /// The root element of the data.
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.data.controller.Tree";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("childPath", _childPath, "");
            state.SetPropertyValue("iconPath", _iconPath, "");
            state.SetPropertyValue("labelPath", _labelPath, "");
            state.SetPropertyValue("model", _model, null);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        /// <summary>
        /// Raises event 'ChangeModel'
        /// </summary>
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

        /// <summary>
        /// Raises event 'ChangeTarget'
        /// </summary>
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
