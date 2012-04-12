using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Form
{
    public partial class Slider : qxDotNet.UI.Core.Widget, qxDotNet.UI.Form.IForm, qxDotNet.UI.Form.INumberForm, qxDotNet.UI.Form.IRange
    {

        #region IForm Members

        bool? IForm.Enabled
        {
            get
            {
                return Enabled;
            }
            set
            {
                Enabled = value;
            }
        }

        string IForm.InvalidMessage
        {
            get
            {
                return _invalidMessage;
            }
            set
            {
                _invalidMessage = value;
            }
        }

        bool? IForm.Required
        {
            get
            {
                return _required;
            }
            set
            {
                _required = value;
            }
        }

        string IForm.RequiredInvalidMessage
        {
            get
            {
                return _requiredInvalidMessage;
            }
            set
            {
                _requiredInvalidMessage = value;
            }
        }

        bool? IForm.Valid
        {
            get
            {
                return _valid;
            }
            set
            {
                _valid = value;
            }
        }

        #endregion

        #region INumberForm Members

        decimal INumberForm.Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        #endregion

        #region IRange Members

        decimal IRange.Maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
                _maximum = (int)value;
            }
        }

        decimal IRange.Minimum
        {
            get
            {
                return _minimum;
            }
            set
            {
                _minimum = (int)value;
            }
        }

        decimal IRange.PageStep
        {
            get
            {
                return _pageStep;
            }
            set
            {
                _pageStep = (int)value;
            }
        }

        decimal IRange.SingleStep
        {
            get
            {
                return _singleStep;
            }
            set
            {
                _singleStep = (int)value;
            }
        }

        #endregion

        protected internal override object ConvertToType(Type type, string value)
        {
            if (type == typeof(decimal))
            {
                if (value == string.Empty)
                {
                    value = Minimum.ToString();
                }
            }
            return base.ConvertToType(type, value);
        }

    }
}
