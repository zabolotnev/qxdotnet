using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Virtual.Selection
{
    /// <summary>
    /// EXPERIMENTAL!  Objects, which are used as delegates for a virtual selection manager may implement any of the methods described in this interface. The delegate does not need implement all of the methods of this interface. If a method is not implemented the selection manager provides a default implementation.  Note: This interface is meant to document the delegate but should not be listed in the implement key of a class unless all methods are really implemented.
    /// </summary>
    public interface ISelectionDelegate
    {


    }
}
