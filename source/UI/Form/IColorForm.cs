using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets which have boolean as their primary
    /// data type like a colorchooser.
    /// 
    /// </summary>
    public interface IColorForm
    {

        /// <summary>
        /// The element's user set value.
        /// 
        /// Sets the element's value.
        /// 
        /// </summary>
        string Value {get; set; }


    }
}
