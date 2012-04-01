using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Decoration
{
    /// <summary>
    /// A decorator is responsible for rendering a widget&#8217;s background and border. It is passed the widget&#8217;s decoration element {@link qx.html.Element} and configures it to display the decoration.  To use the decorator first call the {@link #getMarkup} method. This method will return an HTML fragment containing the decoration. After the decoration has been inserted into the DOM e.g. by using innerHTML the {@link #resize} method must be called to give the decoration the proper size. The first parameter of this call is the root DOM element of the decoration. The resize call can be repeated as needed.  It is also possible to alter the background color of an decoration using the {@link #tint} method.
    /// </summary>
    public interface IDecorator
    {


    }
}
