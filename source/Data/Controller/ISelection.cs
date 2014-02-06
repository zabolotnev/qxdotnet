using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Data.Controller
{
    /// <summary>
    /// Interface for data binding classes offering a selection.
    /// </summary>
    public interface ISelection
    {

        /// <summary>
        /// 
        /// </summary>
        qxDotNet.Data.IListData Selection {get; set; }


    }
}
