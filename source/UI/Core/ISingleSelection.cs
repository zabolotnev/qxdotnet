using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{
    /// <summary>
    /// Each object, which should support single selection have to implement this interface.
    /// </summary>
    public interface ISingleSelection
    {

        /// <summary>
        /// 
        /// </summary>
        qxDotNet.UI.Core.Widget Selection {get; set; }


    }
}
