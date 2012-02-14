using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets. It includes the API for enabled, required and valid states.
    /// </summary>
    public interface IForm
    {

        /// <summary>
        /// 
        /// </summary>
        bool? Enabled {get; set; }

        /// <summary>
        /// 
        /// </summary>
        string InvalidMessage {get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool? Required {get; set; }

        /// <summary>
        /// 
        /// </summary>
        string RequiredInvalidMessage {get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool? Valid {get; set; }


    }
}
