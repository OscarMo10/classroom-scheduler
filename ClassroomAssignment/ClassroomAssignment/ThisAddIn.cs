using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace ClassroomAssignment
{
    public partial class ThisAddIn
    {
        private myUserControl myUserControl1;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;


        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

            myUserControl1 = new myUserControl();
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1, "Classroom Information");
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
