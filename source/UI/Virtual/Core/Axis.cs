using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Core
{
    /// <summary>
    /// EXPERIMENTAL!  The axis maps virtual screen coordinates to item indexes. By default all items have the same size but it is also possible to give specific items a different size.
    /// </summary>
    public partial class Axis : qxDotNet.Core.Object
    {

        private int _defaultItemSize = 0;
        private int _itemCount = 0;
        private int _itemSize = 0;


        /// <summary>
        /// 
        /// </summary>
        public int DefaultItemSize
        {
            get
            {
                return _defaultItemSize;
            }
            set
            {
               _defaultItemSize = value;
            }
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public int ItemSize
        {
            get
            {
                return _itemSize;
            }
            set
            {
               _itemSize = value;
            }
        }


        public override string GetTypeName()
        {
            return "qx.ui.virtual.core.Axis";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("defaultItemSize", _defaultItemSize, 0);
            state.SetPropertyValue("itemCount", _itemCount, 0);
            state.SetPropertyValue("itemSize", _itemSize, 0);

            if (Change != null)
            {
                state.SetEvent("change", false);
            }

        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "change")
            {
                OnChange();
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
        /// Every change to the axis configuration triggers this event.
        /// </summary>
        public event EventHandler Change;

    }
}
