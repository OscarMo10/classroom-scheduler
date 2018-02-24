
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

namespace ClassroomAssignment
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
            Spire.Xls.Workbook MerBook = new Spire.Xls.Workbook();
            MerBook.LoadFromFile("Celal1.xlsx");
            Spire.Xls.Worksheet MerSheet = MerBook.Worksheets[0];

            Spire.Xls.Workbook SouBook1 = new Spire.Xls.Workbook();
            SouBook1.LoadFromFile("Celal2.xlsx");
            int a = SouBook1.Worksheets[0].LastRow;
            int b = SouBook1.Worksheets[0].LastColumn;
            SouBook1.Worksheets[0].Range[2, 1, a, b].Copy(MerSheet.Range[MerSheet.LastRow + 1, 1, a + MerSheet.LastRow, b]);


            Spire.Xls.Workbook SouBook2 = new Spire.Xls.Workbook();
            SouBook2.LoadFromFile("Celal3.xlsx");
            int c = SouBook2.Worksheets[0].LastRow;
            int d = SouBook2.Worksheets[0].LastColumn;
            SouBook2.Worksheets[0].Range[2, 1, c, d].Copy(MerSheet.Range[MerSheet.LastRow + 1, 1, c + MerSheet.LastRow, d]);

            MerBook.SaveToFile("result.xlsx", ExcelVersion.Version2010);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        void Application_WorkbookBeforeSave(Microsoft.Office.Interop.Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);
            Excel.Range firstRow = activeWorksheet.get_Range("A1");
            firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            Excel.Range newFirstRow = activeWorksheet.get_Range("A1");
            newFirstRow.Value2 = "This text was added by using code";
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
