using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Util.Format
{
    /// <summary>
    /// A formatter and parser for numbers.
    /// </summary>
    public partial class NumberFormat : qxDotNet.Core.Object, qxDotNet.Util.Format.IFormat
    {

        private bool? _groupingUsed = true;
        private decimal _maximumFractionDigits = 0m;
        private decimal _maximumIntegerDigits = 0m;
        private decimal _minimumFractionDigits = 0;
        private decimal _minimumIntegerDigits = 0;
        private string _postfix = "";
        private string _prefix = "";


        /// <summary>
        /// Whether thousand groupings should be used {e.g. &#8220;1,432,234.65&#8221;}.
        /// </summary>
        public bool? GroupingUsed
        {
            get
            {
                return _groupingUsed;
            }
            set
            {
               _groupingUsed = value;
            }
        }

        /// <summary>
        /// The maximum number of fraction digits (digits after the decimal separator). Superfluous digits will cause rounding (&#8220;1.8277&#8221; -> &#8220;1.83&#8221;)
        /// </summary>
        public decimal MaximumFractionDigits
        {
            get
            {
                return _maximumFractionDigits;
            }
            set
            {
               _maximumFractionDigits = value;
            }
        }

        /// <summary>
        /// The maximum number of integer digits (superfluous digits will be cut off (&#8220;1923&#8221; -> &#8220;23&#8221;).
        /// </summary>
        public decimal MaximumIntegerDigits
        {
            get
            {
                return _maximumIntegerDigits;
            }
            set
            {
               _maximumIntegerDigits = value;
            }
        }

        /// <summary>
        /// The minimum number of fraction digits (digits after the decimal separator). Missing digits will be filled up with 0 (&#8220;1.5&#8221; -> &#8220;1.500&#8221;)
        /// </summary>
        public decimal MinimumFractionDigits
        {
            get
            {
                return _minimumFractionDigits;
            }
            set
            {
               _minimumFractionDigits = value;
            }
        }

        /// <summary>
        /// The minimum number of integer digits (digits before the decimal separator). Missing digits will be filled up with 0 (&#8220;19&#8221; -> &#8220;0019&#8221;).
        /// </summary>
        public decimal MinimumIntegerDigits
        {
            get
            {
                return _minimumIntegerDigits;
            }
            set
            {
               _minimumIntegerDigits = value;
            }
        }

        /// <summary>
        /// Sets the postfix to put after the number {&#8221; %&#8221; -> &#8220;56.13 %&#8221;}.
        /// </summary>
        public string Postfix
        {
            get
            {
                return _postfix;
            }
            set
            {
               _postfix = value;
               OnChangeNumberFormat();
            }
        }

        /// <summary>
        /// The prefix to put before the number {&#8220;EUR &#8221; -> &#8220;EUR 12.31&#8221;}.
        /// </summary>
        public string Prefix
        {
            get
            {
                return _prefix;
            }
            set
            {
               _prefix = value;
               OnChangeNumberFormat();
            }
        }


        public override string GetTypeName()
        {
            return "qx.util.format.NumberFormat";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("groupingUsed", _groupingUsed, true);
            state.SetPropertyValue("maximumFractionDigits", _maximumFractionDigits, 0m);
            state.SetPropertyValue("maximumIntegerDigits", _maximumIntegerDigits, 0m);
            state.SetPropertyValue("minimumFractionDigits", _minimumFractionDigits, 0);
            state.SetPropertyValue("minimumIntegerDigits", _minimumIntegerDigits, 0);
            state.SetPropertyValue("postfix", _postfix, "");
            state.SetPropertyValue("prefix", _prefix, "");


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

        protected virtual void OnChangeNumberFormat()
        {
            if (ChangeNumberFormat != null)
            {
                ChangeNumberFormat.Invoke(this, System.EventArgs.Empty);
            }
        }

        /// <summary>
        /// Fired on change of the property {@link #postfix}.
        /// </summary>
        public event EventHandler ChangeNumberFormat;

    }
}
