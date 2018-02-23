using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace ClassroomAssignment
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Excel.Worksheet activeWorksheet = Globals.ThisAddIn.Application.ActiveSheet;
            /*
            Excel.Range firstRow = activeWorksheet.get_Range("A1");
            foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                firstRow.Value = day.ToString();
                firstRow = firstRow.Offset[0, 1];
            }
            */

            activeWorksheet.Range[activeWorksheet.UsedRange].Value = "Hello";


            

        }
    }
}
