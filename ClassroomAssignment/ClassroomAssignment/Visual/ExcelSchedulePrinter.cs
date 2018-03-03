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
        static Dictionary<DayOfWeek, int> DayMap = new Dictionary<DayOfWeek, int>();

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
            DayMap.Add(DayOfWeek.Monday, 3);
            DayMap.Add(DayOfWeek.Tuesday, 4);
            DayMap.Add(DayOfWeek.Wednesday, 5);
            DayMap.Add(DayOfWeek.Thursday, 6);
            DayMap.Add(DayOfWeek.Friday, 7);

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

            Spire.Xls.Workbook template = new Spire.Xls.Workbook();
            template.LoadFromFile("ClassroomGridTemplate.xls", Spire.Xls.ExcelVersion.Version97to2003);
            Spire.Xls.Workbook scheduleBook = new Spire.Xls.Workbook();

            foreach (string room in roomWithCourses)
            {
                Spire.Xls.Worksheet worksheet = scheduleBook.Worksheets.AddCopy(template.Worksheets[0]);
                worksheet.Name = room;
                worksheet.Range[RoomNameCell].Value = room;
                
                //printHeaders(worksheet);
                //printTimes(worksheet);
                PrintCourses(worksheet, roomCourseMap[room]);
            }

            //scheduleBook.Worksheets[0].Visibility = Spire.Xls.WorksheetVisibility.StrongHidden;
            //scheduleBook.Worksheets[1].Visibility = Spire.Xls.WorksheetVisibility.StrongHidden;
            scheduleBook.SaveToFile("schedule.xls");
            Globals.ThisAddIn.Application.ActiveWorkbook.Sheets.Add(Type: "schedule.xls");
            Excel.Worksheet sheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets["Sheet1"];
            sheet.Visible = XlSheetVisibility.xlSheetHidden;
            sheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets["Sheet1 (2)"];
            sheet.Visible = XlSheetVisibility.xlSheetHidden;
            sheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets["Sheet2"];
            sheet.Visible = XlSheetVisibility.xlSheetHidden;
            sheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets["Sheet3"];
            sheet.Visible = XlSheetVisibility.xlSheetHidden;
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

        private void PrintCourses(Spire.Xls.Worksheet worksheet, List<Course> courses)
        {
            foreach (Course course in courses)
            {
                foreach (DayOfWeek meetingDay in course.MeetingDays)
                {
                    int column = DayMap[meetingDay];
                    int startRow = GetRowForTime(course.StartTime.Value);
                    int endRow = GetRowForTime(course.EndTime.Value);

                    Spire.Xls.CellRange startCell = worksheet.Range[startRow, column, endRow, column];
                    startCell.Merge();
                    startCell.Value = course.Course_Label + "\n" + course.Instructor + "\n" + course.MeetingPattern;
                    worksheet.AutoFitColumn(column);
                    worksheet.Columns[column].VerticalAlignment = Spire.Xls.VerticalAlignType.Center;
                }
            }

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
