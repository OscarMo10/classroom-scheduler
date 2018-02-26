using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassroomAssignment.Model.Utils
{
    public class DateUtil
    {
        private static Dictionary<string, string> DayNameMatcher = new Dictionary<string, string>();

        static DateUtil()
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
            try
            {
                return DayNameMatcher[dayAbbreviation];
            }
            catch (Exception e)
            {
                LogUtil.Debug(e.Message);
                return null;
            }
        }
    }
}
