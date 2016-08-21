using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Progressive
{
    /// <summary>
    /// State of renderering by Progressive.
    /// 
    /// </summary>
    public partial class State : qxDotNet.Core.Object
    {

//TODO: private _var _batchSize = null;
//TODO: private _var _model = null;
//TODO: private _var _pane = null;
//TODO: private _var _progressive = null;
//TODO: private _var _rendererData = null;
//TODO: private _var _userData = null;



        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.progressive.State";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);


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
