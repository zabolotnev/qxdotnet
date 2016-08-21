using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    /// <summary>
    /// Each object, which should be managed by a {@link RadioGroup} have to
    /// implement this interface.
    /// 
    /// </summary>
    public interface IRadioItem
    {

        /// <summary>
        /// Get the radiogroup, which manages this item
        /// 
        /// Set the radiogroup, which manages this item
        /// 
        /// </summary>
        qxDotNet.UI.Form.RadioGroup Group {get; set; }

        /// <summary>
        /// Get whether the item is checked
        /// 
        /// Set whether the item is checked
        /// 
        /// </summary>
        bool? Value {get; set; }


    }
}
