using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all widgets which deal with ranges. The spinner is a good example for a range using widget.
    /// </summary>
    public interface IRange
    {

        /// <summary>
        /// 
        /// </summary>
        decimal Maximum {get; set; }

        /// <summary>
        /// 
        /// </summary>
        decimal Minimum {get; set; }

        /// <summary>
        /// 
        /// </summary>
        decimal PageStep {get; set; }

        /// <summary>
        /// 
        /// </summary>
        decimal SingleStep {get; set; }


    }
}
