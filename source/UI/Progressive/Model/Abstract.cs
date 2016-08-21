using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Progressive.Model
{
    /// <summary>
    /// Data Model for Progressive renderer.
    /// 
    /// </summary>
    public abstract partial class Abstract : qxDotNet.Core.Object
    {




        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.progressive.model.Abstract";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);

            if (DataAvailable != null)
            {
                state.SetEvent("dataAvailable", false);
            }

        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
            if (eventName == "dataAvailable")
            {
                OnDataAvailable();
            }
        }

        /// <summary>
        /// Raises event 'DataAvailable'
        /// </summary>
        protected virtual void OnDataAvailable()
        {
            if (DataAvailable != null)
            {
                DataAvailable.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// This event is fired when new data has been added to the data model. It
        /// typically informs Progressive to begin its rendering process.
        /// 
        /// The event data is an integer: the number of elements now available on
        /// the element queue.
        /// 
        /// </summary>
        public event EventHandler DataAvailable;

    }
}
