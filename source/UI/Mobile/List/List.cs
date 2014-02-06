using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Mobile.List
{
    /// <summary>
    /// The list widget displays the data of a model in a list.  Example  Here is a little example of how to use the widget.     // Data for the list  var data = [  {title : \Row1\, subtitle : \Sub1\},  {title : \Row2\, subtitle : \Sub2\},  {title : \Row3\, subtitle : \Sub3\}  ];   // Create the list with a delegate that  // configures the list item.  var list = new qx.ui.mobile.list.List({  configureItem : function(item, data, row)  {  item.setTitle(data.title);  item.setSubtitle(data.subtitle);  item.setShowArrow(true);  }  });   // Set the model of the list  list.setModel(new qx.data.Array(data));   // Add an changeSelection event  list.addListener(\changeSelection\, function(evt) {  alert(\Index:\ + evt.getData())  }, this);   this.getRoot().add(list);   This example creates a list with a delegate that configures the list item with the given data. A listener for the event {@link #changeSelection} is added.
    /// </summary>
    public partial class List : qxDotNet.UI.Mobile.Core.Widget
    {

//        private _var _delegate = null;
        private int _itemCount = 0;
        private qxDotNet.Data.Array _model = null;


        /// <summary>
        /// Number of items to display. Auto set by model. Reset to limit the amount of data that should be displayed.
        /// </summary>
        public int ItemCount
        {
            get
            {
                return _itemCount;
            }
            set
            {
               _itemCount = value;
            }
        }

        /// <summary>
        /// The model to use to render the list.
        /// </summary>
        public qxDotNet.Data.Array Model
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
            return "qx.ui.mobile.list.List";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("itemCount", _itemCount, 0);
            state.SetPropertyValue("model", _model, null);

            if (ChangeSelection != null)
            {
                state.SetEvent("changeSelection", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "changeSelection")
            {
                OnChangeSelection();
            }
        }

        protected virtual void OnChangeDelegate()
        {
            if (ChangeDelegate != null)
            {
                ChangeDelegate.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #delegate}.
        /// </summary>
        public event EventHandler ChangeDelegate;

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

        protected virtual void OnChangeSelection()
        {
            if (ChangeSelection != null)
            {
                ChangeSelection.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired when the selection is changed.
        /// </summary>
        public event EventHandler ChangeSelection;

    }
}
