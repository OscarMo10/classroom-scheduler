namespace ClassroomAssignment.View
{
    partial class Home
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
            this.StartProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartProject
            // 
            this.StartProject.Location = new System.Drawing.Point(89, 154);
            this.StartProject.Name = "StartProject";
            this.StartProject.Size = new System.Drawing.Size(194, 23);
            this.StartProject.TabIndex = 0;
            this.StartProject.Text = "Create Workbook from Documents";
            this.StartProject.UseVisualStyleBackColor = true;
            this.StartProject.Click += new System.EventHandler(this.StartProject_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartProject);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(390, 346);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartProject;
    }
}
