using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassroomAssignment.Utils
{
    public class TimeUtil
    {
        // <summary>Converts time string to a timespan</summary>
        // <param name="timeStr">string of format "hh:mm (am|pm)"</param>
        public static TimeSpan StringToTimeSpan(string timeStr)
        {
            Regex timePattern = new Regex(@"(\d{1,2}):(\d{1,2})(am|pm)");
            Match match = timePattern.Match(timeStr);

            if (!match.Success)
            {
                throw new ArgumentException("Invalid time string argument provided.");
            }

            string hrString = match.Groups[1].Value;
            var amPm = match.Groups[3].Value;

            int hr;
            if (amPm.Equals("am"))
            {
                hr = militaryHr(hrString, false);
            }
            else
            {
                hr = militaryHr(hrString, true);
            }

            string minStr = match.Groups[2].Value;
            int min = int.Parse(minStr);

            return new TimeSpan(hr, min, 0);
        }

        private static int militaryHr(string timeStr, bool pm)
        {
            if (pm && timeStr.Equals("12"))
            {
                return 13;
            }
            if (!pm && timeStr.Equals("12"))
            {
                return 0;
            }
            
            return int.Parse(timeStr);
        }
    }
}
