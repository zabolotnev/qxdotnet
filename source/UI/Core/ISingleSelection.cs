using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Core
{
    /// <summary>
    /// Each object, which should support single selection have to
    /// implement this interface.
    /// 
    /// </summary>
    public interface ISingleSelection
    {

        /// <summary>
        /// Returns an array of currently selected items.
        /// 
        /// Note: The result is only a set of selected items, so the order can
        /// differ from the sequence in which the items were added.
        /// 
        /// Replaces current selection with the given items.
        /// 
        /// </summary>
        qxDotNet.UI.Core.Widget Selection {get; set; }


    }
}
