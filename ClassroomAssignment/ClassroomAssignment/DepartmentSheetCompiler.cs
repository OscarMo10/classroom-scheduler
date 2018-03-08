using ClassroomAssignment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ClassroomAssignment
{
    class DepartmentSheetCompiler
    {
        public static void CompileFiles(string[] files)
        {
            Globals.ThisAddIn.Application.ScreenUpdating = false;
            

            Excel.Worksheet dataSheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets.Add();
            dataSheet.Visible = Excel.XlSheetVisibility.xlSheetHidden;
            dataSheet.Name = "original data";
            addHeaderToSheet(files[0], dataSheet);

            foreach (string dataFile in files)
            {
                appendDataToSheet(dataFile, dataSheet);
            }

            dataSheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;
            Globals.ThisAddIn.Application.ScreenUpdating = true;
            Globals.ThisAddIn.Application.ActiveWindow.Visible = true;
            
            
        }

        private static void addHeaderToSheet(string dataFile, Excel.Worksheet dest)
        {
            Excel.Worksheet srcSheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets.Add(Type: dataFile);
            Excel.Range headerRange = getHeaderRange(srcSheet);
            headerRange.Copy(dest.Cells[1, 1]);
            ExcelUtil.DeleteWorksheetQuietly(srcSheet);
        }

        private static Excel.Range getHeaderRange(Excel.Worksheet src)
        {
            string firstCellLoc = src.Cells[1, 1].Address();
            string lastCellLoc = src.Cells[3, src.UsedRange.Columns.Count].Address();
            string rangeStr = String.Format("{0}:{1}", firstCellLoc, lastCellLoc);

            return src.Range[rangeStr];
        }

        private static void appendDataToSheet(string fileName, Excel.Worksheet dest)
        {
            Excel.Worksheet srcSheet = Globals.ThisAddIn.Application.ActiveWorkbook.Sheets.Add(Type: fileName);
            Excel.Range srcRange = getSrcRange(srcSheet);
            Excel.Range destRange = getDestRange(dest);
            srcRange.Copy(destRange);
            ExcelUtil.DeleteWorksheetQuietly(srcSheet);
        }

        private static Excel.Range getSrcRange(Excel.Worksheet src)
        {
            var firstCellAddress = "A4";
            var lastCellAddress = src.Cells[src.UsedRange.Rows.Count, src.UsedRange.Columns.Count].Address();
            var rangeAddress = String.Format("{0}:{1}", firstCellAddress, lastCellAddress);
            return src.Range[rangeAddress];
        }

        private static  Excel.Range getDestRange(Excel.Worksheet dest)
        {
            var copyRow = dest.UsedRange.Rows.Count + 1;
            var copyColumn = 1;

            return dest.Cells[copyRow, copyColumn];
        }
    }
}
