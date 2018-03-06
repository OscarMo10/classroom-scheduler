using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomAssignment
{
    public partial class myUserControl : UserControl
    {
        public myUserControl()
        {
            InitializeComponent();
            PopulateDataGridView();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReadXMLButton_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Eric\\source\\repos\\classroom-scheduler\\ClassroomAssignment\\ClassroomAssignment\\XML\\RoomInfo.xml";

            RoomDataSet.ReadXml(filePath);

            dataGridView1.DataSource = RoomDataSet;
            dataGridView1.DataMember = "Room";
        }

        private void ShowSchemaButton_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            RoomDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
