
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using Spire.Xls;
using System.IO;
using System.Diagnostics;
using ClassroomAssignment.Model.Visual;
using ClassroomAssignment.Repo;
using ClassroomAssignment.Model.Repo;
using ClassroomAssignment.Model;
using System.Text.RegularExpressions;
using ClassroomAssignment.Model.Utils;
using ClassroomAssignment.Utils;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;

namespace ClassroomAssignment
{
    public partial class ThisAddIn
    {
        private View.Home myUserControl1;
        Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        private IEnumerable<string> DataSheetsName;
        Excel.Workbook ProjectWorkbook;


        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //this.Application.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);


            myUserControl1 = new View.Home();
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "My Task Pane");
            myCustomTaskPane.Visible = true;

            myCustomTaskPane.VisibleChanged +=
                new EventHandler(taskPaneValue_VisibleChanged);

           
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //Test comment erikson 2-17-18
        }

        private void taskPaneValue_VisibleChanged(object sender, System.EventArgs e)
        {
            Globals.Ribbons.ManageTaskPaneRibbon.toggleButton1.Checked =
                myCustomTaskPane.Visible;
        }

        public Microsoft.Office.Tools.CustomTaskPane TaskPane
        {
            get
            {
                return myCustomTaskPane;
            }
        }

        public void StartProject()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            var result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                var pathToDocs = folderBrowser.SelectedPath;
                string[] docLocations = Directory.GetFiles(pathToDocs);
                //DepartmentSheetCompiler.CompileFiles(docLocations);
            }

            FileStream f = File.OpenRead("ClassroomGridTemplate.xls");
            IWorkbook workbook = new HSSFWorkbook(f);
            workbook.MissingCellPolicy = MissingCellPolicy.CREATE_NULL_AS_BLANK;
            f.Close();
            ExcelSchedulePrinter e = new ExcelSchedulePrinter();
            e.Workbook = workbook;

            new ScheduleVisualization(new HardCodedCourseRepo(), null, e).PrintSchedule();

            using (var fileStream = File.Create("test.xls"))
            {
                workbook.Write(fileStream);
            }

            workbook.Close();
        }


        private void initCourseRepo()
        {
            Excel.Worksheet worksheet = Application.ActiveWorkbook.Sheets["data1"];
            List<Course> courses = parseDataSheet(worksheet);
            InMemoryCourseRepository.initInstance("Fall 2018", courses);
            new ScheduleVisualization(InMemoryCourseRepository.getInstance(), null, new ExcelSchedulePrinter()).PrintSchedule();



            
        }

        private List<Course> parseDataSheet(Excel.Worksheet worksheet)
        {
            string startLoc = "A4";
            Excel.Range currCell = worksheet.get_Range(startLoc);

            List<Course> courseList = new List<Course>();
            while (!string.IsNullOrEmpty(currCell.Text))
            {
                currCell = currCell.Offset[1, 1];
                while(!string.IsNullOrEmpty(currCell.Text))
                {
                    Course course = parseCourseFromRow(currCell);
                    courseList.Add(course);
                    currCell = currCell.Offset[1, 0];
                }
                currCell = currCell.Offset[0, -1];
            }

            return courseList;
        }
        
        private Course parseCourseFromRow(Excel.Range cell)
        {
            var patternLong = @"Peter Kiewit Institute (\d+)";
            var patternShort = @"PKI (\d+)";

            Course course = new Course();
            Match match;

            // get course title
            cell = cell.Offset[0, 9];
            course.Course_Label = cell.Text;

            // get meeting pattern
            cell = cell.Offset[0, 3];
            course.MeetingPattern = cell.Text;
            match = Regex.Match(course.MeetingPattern, DataConstants.MeetingPatternOptions.TIME_PATTERN);
            if (match.Success)
            {
                Group daysOfWeekGroup = match.Groups["daysOfWeek"];
                course.MeetingDays = new List<DayOfWeek>();
                var day = daysOfWeekGroup.Value;
                int i = 0;
                while (day.Length > 1)
                {
                    if(day[0] == 'T')
                    {
                        if (day[1] == 'H')
                        {
                            course.MeetingDays.Add(Model.Utils.DateUtil.ShortNameToDayOfWeek("TH"));
                            day = day.Remove(0, 2);
                        }
                        else
                        {
                            course.MeetingDays.Add(Model.Utils.DateUtil.ShortNameToDayOfWeek("T"));
                            day = day.Remove(0, 1);
                        }
                    }
                    else
                    {
                        course.MeetingDays.Add(Model.Utils.DateUtil.ShortNameToDayOfWeek(day[0].ToString()));
                        day = day.Remove(0, 1);
                    }
                    
                }

                if (day.Length != 0) course.MeetingDays.Add(Model.Utils.DateUtil.ShortNameToDayOfWeek(day));


                int hrs = int.Parse(match.Groups["startTimeHr"].Value);
                int min = int.Parse(match.Groups["startTimeMin"].Value);
                bool isPM = match.Groups["startTimePM"].Value.Equals("pm");

                if (isPM && hrs < 12)
                {
                    hrs += 12;
                }

                course.StartTime = new TimeSpan(hrs, min, 0);

                hrs = int.Parse(match.Groups["endTimeHr"].Value);
                min = int.Parse(match.Groups["endTimeMin"].Value);
                isPM = match.Groups["endTimePM"].Value.Equals("pm");

                if (isPM && hrs < 12)
                {
                    hrs += 12;
                }
            

                course.EndTime = new TimeSpan(hrs, min, 0);
            }
            

            // get instructor
            cell = cell.Offset[0, 1];
            course.Instructor = cell.Text;

            // get room
            cell = cell.Offset[0, 1];
            course.Room = cell.Text;
            match = Regex.Match(course.Room, patternLong);
            if (match.Success)
            {
                course.AlreadyAssignedRoom = true;
                course.NeedsRoom = true;
                course.RoomAssignment = String.Format("{0}", match.Groups[0]);
            }
            


            // get comments
            cell = cell.Offset[0, 21];
            course.Comments = cell.Text;
            match = Regex.Match(course.Comments, patternShort);
            if(match.Success)
            {
                course.AlreadyAssignedRoom = true;
                course.NeedsRoom = true;
                course.RoomAssignment = String.Format("{0}", match.Groups[0]);
            }

            // get notes
            cell = cell.Offset[0, 1];
            course.Notes = cell.Text;
            match = Regex.Match(course.Comments, patternShort);
            if (match.Success)
            {
                course.AlreadyAssignedRoom = true;
                course.NeedsRoom = true;
                course.RoomAssignment = String.Format("{0}", match.Groups[0]);
            }

            

            return course;
            
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
