using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Html
{
    /// <summary>
    /// High-performance, high-level DOM element creation and management.  Includes support for HTML and style attributes. Elements also have got a powerful children and visibility management.  Processes DOM insertion and modification with advanced logic to reduce the real transactions.  From the view of the parent you can use the following children management methods: {@link #getChildren}, {@link #indexOf}, {@link #hasChild}, {@link #add}, {@link #addAt}, {@link #remove}, {@link #removeAt}, {@link #removeAll}  Each child itself also has got some powerful methods to control its position: {@link #getParent}, {@link #free}, {@link #insertInto}, {@link #insertBefore}, {@link #insertAfter}, {@link #moveTo}, {@link #moveBefore}, {@link #moveAfter},
    /// </summary>
    public partial class Element : qxDotNet.Core.Object
    {

//        private _var _attribute = null;
        private string _nodeName = "";
//        private _var _style = null;
        private string _textSelection = "";


        /// <summary>
        /// 
        /// </summary>
        public string NodeName
        {
            get
            {
                return _nodeName;
            }
            set
            {
               _nodeName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TextSelection
        {
            get
            {
                return _textSelection;
            }
            set
            {
               _textSelection = value;
            }
        }


        protected internal override string GetTypeName()
        {
            return "qx.html.Element";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("nodeName", _nodeName, "");
            state.SetPropertyValue("textSelection", _textSelection, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
