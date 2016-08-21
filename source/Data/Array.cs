using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data
{
    /// <summary>
    /// The data array is a special array used in the data binding context of
    /// qooxdoo. It does not extend the native array of JavaScript but its a wrapper
    /// for it. All the native methods are included in the implementation and it
    /// also fires events if the content or the length of the array changes in
    /// any way. Also the .length property is available on the array.
    /// 
    /// </summary>
    public partial class Array : qxDotNet.Core.Object, qxDotNet.Data.IListData
    {

        private bool? _autoDisposeItems = false;


        /// <summary>
        /// Flag to set the dispose behavior of the array. If the property is set to
        /// true, the array will dispose its content on dispose, too.
        /// 
        /// </summary>
        public bool? AutoDisposeItems
        {
            get
            {
                return _autoDisposeItems;
            }
            set
            {
               _autoDisposeItems = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.data.Array";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("autoDisposeItems", _autoDisposeItems, false);

            if (Change != null)
            {
                state.SetEvent("change", false);
            }
            if (ChangeLength != null)
            {
                state.SetEvent("changeLength", false);
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
            if (eventName == "changeLength")
            {
                OnChangeLength();
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
        /// The change event which will be fired if there is a change in the array.
        /// The data contains a map with five key value pairs:
        /// start: The start index of the change.
        /// end: The end index of the change.
        /// type: The type of the change as a String. This can be 'add',
        /// 'remove', 'order' or 'add/remove'
        /// added: The items which has been added (as a JavaScript array)
        /// removed: The items which has been removed (as a JavaScript array)
        /// 
        /// </summary>
        public event EventHandler Change;

        /// <summary>
        /// Raises event 'ChangeLength'
        /// </summary>
        protected virtual void OnChangeLength()
        {
            if (ChangeLength != null)
            {
                ChangeLength.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The changeLength event will be fired every time the length of the
        /// array changes.
        /// 
        /// </summary>
        public event EventHandler ChangeLength;

    }
}
