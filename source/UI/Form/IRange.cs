using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all widgets which deal with ranges. The spinner is a good
    /// example for a range using widget.
    /// 
    /// </summary>
    public interface IRange
    {

        /// <summary>
        /// Return the current set maximum of the range.
        /// 
        /// Set the maximum value of the range.
        /// 
        /// </summary>
        decimal Maximum {get; set; }

        /// <summary>
        /// Return the current set minimum of the range.
        /// 
        /// Set the minimum value of the range.
        /// 
        /// </summary>
        decimal Minimum {get; set; }

        /// <summary>
        /// Returns the value which will be stepped in a page step in the range.
        /// 
        /// Sets the value for page steps in the range.
        /// 
        /// </summary>
        decimal PageStep {get; set; }

        /// <summary>
        /// Returns the value which will be stepped in a single step in the range.
        /// 
        /// Sets the value for single steps in the range.
        /// 
        /// </summary>
        decimal SingleStep {get; set; }


    }
}
