using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Util.Format
{

    public partial class DateFormat : qxDotNet.Core.Object, qxDotNet.Util.Format.IFormat
    {

        private string _format = "";

        public DateFormat(string format)
        {
            _format = format;
        }

        public DateFormat(string format, string locale)
        {
            _format = format;
            Locale = locale;
        }

        protected internal override string GetCustomConstructor()
        {
            return "\"" + _format.EscapeToJS() + "\"";
        }

    }
}
