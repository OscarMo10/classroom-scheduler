namespace ClassroomAssignment
{
    partial class myUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxSeating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.MaxSeating});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 241);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.Name = "RoomNumber";
            // 
            // MaxSeating
            // 
            this.MaxSeating.HeaderText = "Max Seating";
            this.MaxSeating.Name = "MaxSeating";
            // 
            // myUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "myUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        private void PopulateDataGridView()
        {

            string[] row0 = { "153", "40" };
            string[] row1 = { "155", "45" };
            string[] row2 = { "157", "24" };
            string[] row3 = { "160", "44" };
            string[] row4 = { "161", "30" };
            string[] row5 = { "164", "56" };
            string[] row6 = { "252", "58" };
            string[] row7 = { "256", "40" };
            string[] row8 = { "259", "20" };
            string[] row9 = { "260-Lab", "40" };
            string[] row10 = { "261", "24" };
            string[] row11 = { "263", "48" };
            string[] row12 = { "269", "30" };
            string[] row13 = { "270", "16" };
            string[] row14 = { "274", "30" };
            string[] row15 = { "276-Lab", "35" };
            string[] row16 = { "278-Lab", "35" };
            string[] row17 = { "279", "30" };
            string[] row18 = { "361-Lab", "35" };


            dataGridView1.Rows.Add(row0);
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);
            dataGridView1.Rows.Add(row5);
            dataGridView1.Rows.Add(row6);
            dataGridView1.Rows.Add(row7);
            dataGridView1.Rows.Add(row8);
            dataGridView1.Rows.Add(row9);
            dataGridView1.Rows.Add(row10);
            dataGridView1.Rows.Add(row11);
            dataGridView1.Rows.Add(row12);
            dataGridView1.Rows.Add(row13);
            dataGridView1.Rows.Add(row14);
            dataGridView1.Rows.Add(row15);
            dataGridView1.Rows.Add(row16);
            dataGridView1.Rows.Add(row17);
            dataGridView1.Rows.Add(row18);

            dataGridView1.Columns[0].DisplayIndex = 0;

        }


        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxSeating;
    }
}
