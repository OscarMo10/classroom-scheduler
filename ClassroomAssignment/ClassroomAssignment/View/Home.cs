using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomAssignment.View
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void StartProject_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.StartProject();


        }
    }
}
