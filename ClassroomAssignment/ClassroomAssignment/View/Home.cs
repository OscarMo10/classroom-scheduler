using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ClassroomAssignment.Repo;

namespace ClassroomAssignment.View
{
    public partial class Home : System.Windows.Forms.UserControl
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

        private void Home_Load(object sender, EventArgs e)
        {
            DataGridView gridView = Controls["dataGridView1"] as DataGridView;
            gridView.DataSource = new HardCodedCourseRepo().Courses;
        }
    }
}
