using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data
{
    /// <summary>
    /// The data array is a special array used in the data binding context of qooxdoo. It does not extend the native array of JavaScript but its a wrapper for it. All the native methods are included in the implementation and it also fires events if the content or the length of the array changes in any way. Also the .length property is available on the array.
    /// </summary>
    public partial class Array : qxDotNet.Core.Object, qxDotNet.Data.IListData
    {

        private bool? _autoDisposeItems = false;
//        private _var _item = null;


        /// <summary>
        /// Flag to set the dispose behavior of the array. If the property is set to true, the array will dispose its content on dispose, too.
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


        public override string GetTypeName()
        {
            return "qx.data.Array";
        }

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
            if (ChangeBubble != null)
            {
                state.SetEvent("changeBubble", false);
            }

        }

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
            if (eventName == "changeBubble")
            {
                OnChangeBubble();
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
        /// The change event which will be fired if there is a change in the array. The data contains a map with three key value pairs: start: The start index of the change. end: The end index of the change. type: The type of the change as a String. This can be &#8216;add&#8217;, &#8216;remove&#8217; or &#8216;order&#8217; items: The items which has been changed (as a JavaScript array).
        /// </summary>
        public event EventHandler Change;

        protected virtual void OnChangeLength()
        {
            if (ChangeLength != null)
            {
                ChangeLength.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The changeLength event will be fired every time the length of the array changes.
        /// </summary>
        public event EventHandler ChangeLength;

        protected virtual void OnChangeBubble()
        {
            if (ChangeBubble != null)
            {
                ChangeBubble.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// The change event which will be fired on every change in the model no matter what property changes. This event bubbles so the root model will fire a change event on every change of its children properties too.  Note that properties are required to call {@link #_applyEventPropagation} on apply for changes to be tracked as desired. It is already taken care of that properties created with the {@link qx.data.marshal.Json} marshaler call this method.  The data will contain a map with the following three keys  value: The new value of the property  old: The old value of the property.  name: The name of the property changed including its parent  properties separated by dots. Due to that, the getOldData method will always return null because the old data is contained in the map.
        /// </summary>
        public event EventHandler ChangeBubble;

    }
}
