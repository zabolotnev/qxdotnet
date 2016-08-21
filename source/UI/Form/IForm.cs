using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets. It includes the API for enabled,
    /// required and valid states.
    /// 
    /// </summary>
    public interface IForm
    {

        /// <summary>
        /// Return the current set enabled state.
        /// 
        /// Set the enabled state of the widget.
        /// 
        /// </summary>
        bool? Enabled {get; set; }

        /// <summary>
        /// Returns the invalid message of the widget.
        /// 
        /// Sets the invalid message of the widget.
        /// 
        /// </summary>
        string InvalidMessage {get; set; }

        /// <summary>
        /// Return the current required state of the widget.
        /// 
        /// Sets the required state of a widget.
        /// 
        /// </summary>
        bool? Required {get; set; }

        /// <summary>
        /// Returns the invalid message if required of the widget.
        /// 
        /// Sets the invalid message if required of the widget.
        /// 
        /// </summary>
        string RequiredInvalidMessage {get; set; }

        /// <summary>
        /// Returns the valid state of the widget.
        /// 
        /// Sets the valid state of the widget.
        /// 
        /// </summary>
        bool? Valid {get; set; }


    }
}
