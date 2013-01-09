using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{

    public partial class SelectBox : qxDotNet.UI.Form.AbstractSelectBox, qxDotNet.UI.Core.ISingleSelection, qxDotNet.UI.Form.IModelSelection
    {

        protected internal override string GetGetPropertyAccessor(string name, bool isRef)
        {
            if (name == "selection")
            {
                return GetReference() + ".getSelection().pop()._id_";
            }
            else
            {
                return base.GetGetPropertyAccessor(name, isRef);
            }
        }

        protected internal override string GetSetPropertyValueExpression(string name, object value)
        {
            if (name == "selection")
            {
                if (value == null)
                {
                    return GetReference() + "." + GetSetPropertyAccessor(name) + "([]);\n";
                }
                else
                {
                    return GetReference() + "." + GetSetPropertyAccessor(name) + "([" + GetClientValue(value) + "]);\n";
                }
            }
            else
            {
                return base.GetSetPropertyValueExpression(name, value);
            }
        }

    }
}
