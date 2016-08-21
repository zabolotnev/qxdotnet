using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets which have date as their primary
    /// data type like datechooser's.
    /// 
    /// </summary>
    public interface IDateForm
    {

        /// <summary>
        /// The element's user set value.
        /// 
        /// Sets the element's value.
        /// 
        /// </summary>
        DateTime? Value {get; set; }


    }
}
