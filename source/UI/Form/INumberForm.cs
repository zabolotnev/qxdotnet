using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets which use a numeric value as their
    /// primary data type like a spinner.
    /// 
    /// </summary>
    public interface INumberForm
    {

        /// <summary>
        /// The element's user set value.
        /// 
        /// Sets the element's value.
        /// 
        /// </summary>
        decimal Value {get; set; }


    }
}
