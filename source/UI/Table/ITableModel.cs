using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Table
{
    /// <summary>
    /// The data model of a table.
    /// 
    /// </summary>
    internal interface ITableModel
    {

        bool Modified { get; }

        void ResetModified();

    }
}
