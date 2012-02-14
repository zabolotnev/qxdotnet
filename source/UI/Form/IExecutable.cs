using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets which are executable in some way. This could be a button for example.
    /// </summary>
    public interface IExecutable
    {

        /// <summary>
        /// 
        /// </summary>
        qxDotNet.UI.Core.Command Command {get; set; }


    }
}
