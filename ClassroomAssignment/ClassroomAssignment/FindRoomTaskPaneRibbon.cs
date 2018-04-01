using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ClassroomAssignment
{
    public partial class FindRoomTaskPaneRibbon
    {
        private void FindRoomTaskPaneRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void FindRoomTB_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.TaskPane1.Visible = ((RibbonToggleButton)sender).Checked;
        }
    }
}
