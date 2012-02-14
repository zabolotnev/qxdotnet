using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qxDotNet
{
    public static class StringExtensions
    {

        public static string EscapeToJS(this string value)
        {
            if (value == null)
            {
                value = "";
            }
            return value.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n");
        }

    }
}
