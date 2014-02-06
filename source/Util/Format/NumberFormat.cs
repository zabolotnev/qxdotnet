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
        private decimal _minimumFractionDigits = 0m;
        private decimal _minimumIntegerDigits = 0m;
        private string _postfix = "";
        private string _prefix = "";


        /// <summary>
        /// Whether thousand groupings should be used {e.g. "1,432,234.65"}.
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
        /// The maximum number of fraction digits (digits after the decimal separator). Superfluous digits will cause rounding ("1.8277" -> "1.83")
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
        /// The maximum number of integer digits (superfluous digits will be cut off ("1923" -> "23").
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
        /// The minimum number of fraction digits (digits after the decimal separator). Missing digits will be filled up with 0 ("1.5" -> "1.500")
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
        /// The minimum number of integer digits (digits before the decimal separator). Missing digits will be filled up with 0 ("19" -> "0019").
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
        /// Sets the postfix to put after the number {" %" -> "56.13 %"}.
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
        /// The prefix to put before the number {"EUR " -> "EUR 12.31"}.
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

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.util.format.NumberFormat";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("groupingUsed", _groupingUsed, true);
            state.SetPropertyValue("maximumFractionDigits", _maximumFractionDigits, 0m);
            state.SetPropertyValue("maximumIntegerDigits", _maximumIntegerDigits, 0m);
            state.SetPropertyValue("minimumFractionDigits", _minimumFractionDigits, 0m);
            state.SetPropertyValue("minimumIntegerDigits", _minimumIntegerDigits, 0m);
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
