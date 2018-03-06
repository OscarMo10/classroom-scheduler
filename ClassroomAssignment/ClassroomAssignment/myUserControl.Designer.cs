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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReadXMLButton = new System.Windows.Forms.Button();
            this.ShowSchemaButton = new System.Windows.Forms.Button();
            this.RoomDataSet = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 273);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ReadXMLButton
            // 
            this.ReadXMLButton.Location = new System.Drawing.Point(30, 6);
            this.ReadXMLButton.Name = "ReadXMLButton";
            this.ReadXMLButton.Size = new System.Drawing.Size(75, 23);
            this.ReadXMLButton.TabIndex = 5;
            this.ReadXMLButton.Text = "Read XML";
            this.ReadXMLButton.UseVisualStyleBackColor = true;
            this.ReadXMLButton.Click += new System.EventHandler(this.ReadXMLButton_Click);
            // 
            // ShowSchemaButton
            // 
            this.ShowSchemaButton.Location = new System.Drawing.Point(217, 6);
            this.ShowSchemaButton.Name = "ShowSchemaButton";
            this.ShowSchemaButton.Size = new System.Drawing.Size(87, 23);
            this.ShowSchemaButton.TabIndex = 6;
            this.ShowSchemaButton.Text = "Show Schema";
            this.ShowSchemaButton.UseVisualStyleBackColor = true;
            this.ShowSchemaButton.Click += new System.EventHandler(this.ShowSchemaButton_Click);
            // 
            // RoomDataSet
            // 
            this.RoomDataSet.DataSetName = "RoomDataSet";
            // 
            // myUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowSchemaButton);
            this.Controls.Add(this.ReadXMLButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "myUserControl";
            this.Size = new System.Drawing.Size(360, 249);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //hardcode for population of datagrid info
        private void PopulateDataGridView()
        {
            /*
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
            */
        }


        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReadXMLButton;
        private System.Windows.Forms.Button ShowSchemaButton;
        private System.Data.DataSet RoomDataSet;
    }
}
