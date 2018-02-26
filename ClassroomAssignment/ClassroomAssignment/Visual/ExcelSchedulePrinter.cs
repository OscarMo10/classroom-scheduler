using ClassroomAssignment.Model.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model.Visual
{
    class ExcelSchedulePrinter : ISchedulePrinter
    {
        static string RoomNameCell = "A3";
        static string RoomCapacityCell = "B3";
        static TimeSpan StartTime = new TimeSpan(7, 30, 0);
        static TimeSpan EndTime = new TimeSpan(10, 0, 0);
        static TimeSpan TimeInterval = new TimeSpan(0, 30, 0);
        static int CellSpanPerTimeInterval = 2;
        static int startTimeLocationRow = 7;
        static Dictionary<TimeSpan, int> TimeMap = new Dictionary<TimeSpan, int>();
        static Dictionary<DayOfWeek, string> DayMap = new Dictionary<DayOfWeek, string>();

        static ExcelSchedulePrinter()
        {

            // initialize TimeMap, maps times to row location
            TimeMap.Add(StartTime, startTimeLocationRow);
            var currTime = StartTime;
            var currRow = startTimeLocationRow;
            while(currTime.CompareTo(EndTime) < 0)
            {
                currTime = currTime.Add(TimeInterval);
                currRow += CellSpanPerTimeInterval;
                TimeMap.Add(currTime, currRow);
            }

            // initialize DayMap: Maps days to column locations
            DayMap.Add(DayOfWeek.Monday, "C");
            DayMap.Add(DayOfWeek.Tuesday, "D");
            DayMap.Add(DayOfWeek.Wednesday, "E");
            DayMap.Add(DayOfWeek.Thursday, "F");
            DayMap.Add(DayOfWeek.Friday, "G");

        }
        



        

        public void Print(ICourseRepository courseRepo, IRoomRepository roomRepo)
        {
            throw new NotImplementedException();
        }
    }
}
