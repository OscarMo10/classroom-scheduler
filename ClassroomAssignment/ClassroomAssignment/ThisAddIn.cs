
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
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
using System.Reflection;

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
            }

            var f = Assembly.GetExecutingAssembly().GetManifestResourceStream("ClassroomAssignment.ClassroomGridTemplate.xls");
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
