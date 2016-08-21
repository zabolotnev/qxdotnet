using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets which have boolean as their primary
    /// data type like a checkbox.
    /// 
    /// </summary>
    public interface IBooleanForm
    {

        /// <summary>
        /// The element's user set value.
        /// 
        /// Sets the element's value.
        /// 
        /// </summary>
        bool? Value {get; set; }


    }
}
