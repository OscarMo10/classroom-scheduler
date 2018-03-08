using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Utils
{
    class ExcelUtil
    {
        public static void DeleteWorksheetQuietly(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            Globals.ThisAddIn.Application.DisplayAlerts = false;
            worksheet.Delete();
            Globals.ThisAddIn.Application.DisplayAlerts = true;

        }
    }
}
