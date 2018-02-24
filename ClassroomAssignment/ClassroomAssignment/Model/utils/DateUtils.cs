using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassroomAssignment.Model.utils
{
    public class DateUtils
    {
        private static Dictionary<string, string> DayNameMatcher;

        static DateUtils()
        {
            DayNameMatcher.Add("Sn", DayOfWeek.Sunday.ToString());
            DayNameMatcher.Add("M", DayOfWeek.Monday.ToString());
            DayNameMatcher.Add("T", DayOfWeek.Tuesday.ToString());
            DayNameMatcher.Add("W", DayOfWeek.Wednesday.ToString());
            DayNameMatcher.Add("TH", DayOfWeek.Thursday.ToString());
            DayNameMatcher.Add("F", DayOfWeek.Friday.ToString());
            DayNameMatcher.Add("S", DayOfWeek.Saturday.ToString());
        }

        public static string ShortToLongDayName(string dayAbbreviation)
        {
            return DayNameMatcher[dayAbbreviation];
        }
    }
}
