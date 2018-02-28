using ClassroomAssignment.Model.Repo;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace ClassroomAssignment.Model.Visual
{
    class ExcelSchedulePrinter : ISchedulePrinter
    {
        static string RoomNameCell = "A3";
        static string RoomCapacityCell = "B3";
        static string TimeHeaderLocation = "B5";
        static int CellSpanPerTimeInterval = 2;
        static int startTimeLocationRow = 6;

        static TimeSpan StartTime = new TimeSpan(7, 30, 0);
        static TimeSpan EndTime = new TimeSpan(22, 0, 0);
        static TimeSpan TimeInterval = new TimeSpan(0, 30, 0);
        
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
            List<Course> courses = courseRepo.Courses;
            IEnumerable<Course> roomedCourses = courses.Where<Course>(x => x.AlreadyAssignedRoom && x.MeetingDays != null);
            Dictionary<string, List<Course>> roomCourseMap = new Dictionary<string, List<Course>>();

            foreach (Course course in roomedCourses)
            {
                if (roomCourseMap.ContainsKey(course.RoomAssignment))
                {
                    roomCourseMap[course.RoomAssignment].Add(course);
                }
                else
                {
                    roomCourseMap.Add(course.RoomAssignment, new List<Course>() { course });
                }
            }

            List<string> roomWithCourses = roomCourseMap.Keys.ToList<string>();

            Excel.Workbook workbook = Globals.ThisAddIn.Application.ActiveWorkbook;
            foreach (string room in roomWithCourses)
            {

                Excel.Worksheet worksheet = workbook.Sheets.Add(Type: "ClassroomGridTemplate.xlsx");
                Globals.ThisAddIn.Application.ScreenUpdating = false;
                worksheet.Name = room;
                Globals.ThisAddIn.Application.ScreenUpdating = false;
                worksheet.get_Range(RoomNameCell).Value = room;
                //printHeaders(worksheet);
                //printTimes(worksheet);
                //PrintCourses(worksheet, roomCourseMap[room]);
            }
        }

        private void printHeaders(Excel.Worksheet worksheet)
        {
            string[] headers = new string[] { "Time", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            Range currentCell = worksheet.get_Range(TimeHeaderLocation);

            for (int i = 0; i < headers.Length; i++)
            {
                currentCell.Value = headers[i];
                currentCell = currentCell.Offset[0, 1];
            }
        }

        private void printTimes(Excel.Worksheet worksheet)
        {
            Range timeHeader = worksheet.get_Range(TimeHeaderLocation);
            Range timeLoc = timeHeader.Offset[1, 0];

            TimeSpan currentTime = StartTime;

            while (currentTime <= EndTime)
            {
                timeLoc.Borders.Weight = XlBorderWeight.xlThin;
                timeLoc.Value = String.Format("{0}{1:D2}", currentTime.Hours, currentTime.Minutes);
                timeLoc = timeLoc.Offset[2, 0];
                currentTime = currentTime.Add(TimeInterval);
            }
        }

        private void PrintCourses(Excel.Worksheet worksheet, List<Course> courses)
        {
            foreach (Course course in courses)
            {
                foreach (DayOfWeek meetingDay in course.MeetingDays)
                {
                    Globals.ThisAddIn.Application.ScreenUpdating = false;
                    string column = DayMap[meetingDay];
                    int startRow = GetRowForTime(course.StartTime.Value);
                    int endRow = GetRowForTime(course.EndTime.Value);

                    string startLoc = String.Format("{0}{1}", column, startRow);
                    string endLoc = String.Format("{0}{1}", column, endRow);
                    Range startCell = worksheet.get_Range(startLoc, endLoc);
                    startCell.Merge();
                    startCell.Value = course.Course_Label;
                }
            }

            Globals.ThisAddIn.Application.ScreenUpdating = true;
        }

        private int GetRowForTime(TimeSpan time)
        {
            int minutes = time.Minutes;
            if (minutes % 30 == 0)
            {
                return TimeMap[time];
            }
            else
            {
                minutes = (minutes / 30) * 30;
                return TimeMap[new TimeSpan(time.Hours, minutes, 0)];
            }
        }

        
    }

    
}
