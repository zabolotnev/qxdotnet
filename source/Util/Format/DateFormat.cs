using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.Util.Format
{
    /// <summary>
    /// A formatter and parser for dates, see
    /// http://www.unicode.org/reports/tr35/#Date_Format_Patterns
    /// 
    /// Here is a quick overview of the format pattern keys:
    /// 
    /// Key &nbsp;Description
    ///  G  era, e.g. "AD"
    ///  y  year
    ///  Y  week year
    ///  u  extended year [Not supported yet]
    ///  Q  quarter
    ///  q  stand-alone quarter
    ///  M  month
    ///  L  stand-alone month
    ///  I  chinese leap month [Not supported yet]
    ///  w  week of year
    ///  W  week of month
    ///  d  day of month
    ///  D  day of year
    ///  F  day of week in month [Not supported yet]
    ///  g  modified Julian day [Not supported yet]
    ///  E  day of week
    ///  e  local day of week
    ///  c  stand-alone local day of week
    ///  a  period of day (am or pm)
    ///  h  12-hour hour
    ///  H  24-hour hour
    ///  K  hour [0-11]
    ///  k  hour [1-24]
    ///  j  special symbol [Not supported yet]
    ///  m  minute
    ///  s  second
    ///  S  fractional second
    ///  A  millisecond in day [Not supported yet]
    ///  z  time zone, specific non-location format
    ///  Z  time zone, rfc822/gmt format
    ///  v  time zone, generic non-location format [Not supported yet]
    ///  V  time zone, like z except metazone abbreviations [Not supported yet]
    /// 
    /// 
    /// (This list is preliminary, not all format keys might be implemented). Most
    /// keys support repetitions that influence the meaning of the format. Parts of the
    /// format string that should not be interpreted as format keys have to be
    /// single-quoted.
    /// 
    /// The same format patterns will be used for both parsing and output formatting.
    /// 
    /// </summary>
    public partial class DateFormat : qxDotNet.Core.Object, qxDotNet.Util.Format.IFormat
    {

        private string _locale = "";


        /// <summary>
        /// The locale used in this DateFormat instance
        /// 
        /// </summary>
        public string Locale
        {
            get
            {
                return _locale;
            }
            set
            {
               _locale = value;
            }
        }


        /// <summary>
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.util.format.DateFormat";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("locale", _locale, "");


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
