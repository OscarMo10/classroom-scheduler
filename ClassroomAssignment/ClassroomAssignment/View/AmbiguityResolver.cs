using ClassroomAssignment.Model;
using ClassroomAssignment.Model.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomAssignment.View
{
    public partial class AmbiguityResolver : Form
    {
        public AmbiguityResolver()
        {
            InitializeComponent();

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(dataGridView1_CurrentCellDirtyStateChanged);

            var courseRepo = InMemoryCourseRepository.getInstance();
            var ambiguousCourses = courseRepo.Courses.FindAll(m => m.AmbiguousAssignment);
            this.dataGridView1.DataSource = ambiguousCourses;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            const string roomAssignmentColName = "roomAssignmentTextBox";
            const string unassignedColName = "unassignedCheckBox";
            const string noRoomNeededColName = "NoRoomNeededCheckBox";

            Course course = dataGridView1.Rows[e.RowIndex].DataBoundItem as Course;
            var currentRow = dataGridView1.Rows[e.RowIndex];
          
            var roomAssignmentCell = currentRow.Cells[roomAssignmentColName];
            var unassignedCell = currentRow.Cells[unassignedColName];
            var noRoomNeededCell = currentRow.Cells[noRoomNeededColName];


            
            var propertyName = dataGridView1.Columns[e.ColumnIndex].Name;
            var cell = dataGridView1.CurrentCell;
            switch (propertyName)
            {
                case roomAssignmentColName:
                    return;

                case unassignedColName:
                    if ((bool)cell.Value)
                    {
                        course.NeedsRoom = true;

                        roomAssignmentCell.ReadOnly = true;
                        roomAssignmentCell.Style.BackColor = Color.LightGray;
                        noRoomNeededCell.ReadOnly = true;
                        noRoomNeededCell.Style.BackColor = Color.LightGray;                        
                    }
                    else
                    {
                        roomAssignmentCell.ReadOnly = true;
                        roomAssignmentCell.Style.BackColor = Color.White;
                        noRoomNeededCell.ReadOnly = true;
                        noRoomNeededCell.Style.BackColor = Color.White;

                    }

                    break;
                case noRoomNeededColName:
                    if ((bool)cell.Value)
                    {
                        course.NeedsRoom = false;

                        roomAssignmentCell.ReadOnly = true;
                        roomAssignmentCell.Style.BackColor = Color.LightGray;
                        unassignedCell.ReadOnly = true;
                        unassignedCell.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        roomAssignmentCell.ReadOnly = true;
                        roomAssignmentCell.Style.BackColor = Color.White;
                        unassignedCell.ReadOnly = true;
                        unassignedCell.Style.BackColor = Color.White;

                    }
                    break;
            }

        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
           if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }




    }
}
