using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table.Model
{
    /// <summary>
    /// A simple table model that provides an API for changing the model data.
    /// 
    /// </summary>
    internal partial class Simple : qxDotNet.UI.Table.Model.Abstract
    {

        private bool? _caseSensitiveSorting = true;


        /// <summary>
        /// Whether sorting should be case sensitive
        /// 
        /// </summary>
        public bool? CaseSensitiveSorting
        {
            get
            {
                return _caseSensitiveSorting;
            }
            set
            {
               _caseSensitiveSorting = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.table.model.Simple";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("caseSensitiveSorting", _caseSensitiveSorting, true);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
