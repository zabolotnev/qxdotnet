using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Form interface for all form widgets which are executable in some way. This
    /// could be a button for example.
    /// 
    /// </summary>
    public interface IExecutable
    {

        /// <summary>
        /// Return the current set command of this executable.
        /// 
        /// Set the command of this executable.
        /// 
        /// </summary>
        qxDotNet.UI.Command.Command Command {get; set; }


    }
}
