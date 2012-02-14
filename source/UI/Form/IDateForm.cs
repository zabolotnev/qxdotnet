using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets which have date as their primary data type like datechooser&#8217;s.
    /// </summary>
    public interface IDateForm
    {

        /// <summary>
        /// 
        /// </summary>
        DateTime? Value {get; set; }


    }
}
