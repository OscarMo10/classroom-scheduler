namespace ClassroomAssignment.View
{
    partial class AmbiguityResolver
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingPatternDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomAttributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCapRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crossListingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needsRoomDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomAssignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classIDDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.catalogNumberDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.sectionNumberDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.sectionTypeDataGridViewTextBoxColumn,
            this.topicDataGridViewTextBoxColumn,
            this.meetingPatternDataGridViewTextBoxColumn,
            this.instructorDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.campusDataGridViewTextBoxColumn,
            this.instructionMethodDataGridViewTextBoxColumn,
            this.creditHrsDataGridViewTextBoxColumn,
            this.gradeModeDataGridViewTextBoxColumn,
            this.attributesDataGridViewTextBoxColumn,
            this.roomAttributesDataGridViewTextBoxColumn,
            this.roomCapRequestDataGridViewTextBoxColumn,
            this.crossListingsDataGridViewTextBoxColumn,
            this.linkToDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.needsRoomDataGridViewCheckBoxColumn,
            this.roomAssignmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(ClassroomAssignment.Model.Course);
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            // 
            // catalogNumberDataGridViewTextBoxColumn
            // 
            this.catalogNumberDataGridViewTextBoxColumn.DataPropertyName = "CatalogNumber";
            this.catalogNumberDataGridViewTextBoxColumn.HeaderText = "CatalogNumber";
            this.catalogNumberDataGridViewTextBoxColumn.Name = "catalogNumberDataGridViewTextBoxColumn";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // sectionNumberDataGridViewTextBoxColumn
            // 
            this.sectionNumberDataGridViewTextBoxColumn.DataPropertyName = "Section_Number";
            this.sectionNumberDataGridViewTextBoxColumn.HeaderText = "Section_Number";
            this.sectionNumberDataGridViewTextBoxColumn.Name = "sectionNumberDataGridViewTextBoxColumn";
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "Course_Title";
            this.courseTitleDataGridViewTextBoxColumn.HeaderText = "Course_Title";
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            // 
            // sectionTypeDataGridViewTextBoxColumn
            // 
            this.sectionTypeDataGridViewTextBoxColumn.DataPropertyName = "Section_Type";
            this.sectionTypeDataGridViewTextBoxColumn.HeaderText = "Section_Type";
            this.sectionTypeDataGridViewTextBoxColumn.Name = "sectionTypeDataGridViewTextBoxColumn";
            // 
            // topicDataGridViewTextBoxColumn
            // 
            this.topicDataGridViewTextBoxColumn.DataPropertyName = "Topic";
            this.topicDataGridViewTextBoxColumn.HeaderText = "Topic";
            this.topicDataGridViewTextBoxColumn.Name = "topicDataGridViewTextBoxColumn";
            // 
            // meetingPatternDataGridViewTextBoxColumn
            // 
            this.meetingPatternDataGridViewTextBoxColumn.DataPropertyName = "MeetingPattern";
            this.meetingPatternDataGridViewTextBoxColumn.HeaderText = "MeetingPattern";
            this.meetingPatternDataGridViewTextBoxColumn.Name = "meetingPatternDataGridViewTextBoxColumn";
            // 
            // instructorDataGridViewTextBoxColumn
            // 
            this.instructorDataGridViewTextBoxColumn.DataPropertyName = "Instructor";
            this.instructorDataGridViewTextBoxColumn.HeaderText = "Instructor";
            this.instructorDataGridViewTextBoxColumn.Name = "instructorDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // campusDataGridViewTextBoxColumn
            // 
            this.campusDataGridViewTextBoxColumn.DataPropertyName = "Campus";
            this.campusDataGridViewTextBoxColumn.HeaderText = "Campus";
            this.campusDataGridViewTextBoxColumn.Name = "campusDataGridViewTextBoxColumn";
            // 
            // instructionMethodDataGridViewTextBoxColumn
            // 
            this.instructionMethodDataGridViewTextBoxColumn.DataPropertyName = "InstructionMethod";
            this.instructionMethodDataGridViewTextBoxColumn.HeaderText = "InstructionMethod";
            this.instructionMethodDataGridViewTextBoxColumn.Name = "instructionMethodDataGridViewTextBoxColumn";
            // 
            // creditHrsDataGridViewTextBoxColumn
            // 
            this.creditHrsDataGridViewTextBoxColumn.DataPropertyName = "CreditHrs";
            this.creditHrsDataGridViewTextBoxColumn.HeaderText = "CreditHrs";
            this.creditHrsDataGridViewTextBoxColumn.Name = "creditHrsDataGridViewTextBoxColumn";
            // 
            // gradeModeDataGridViewTextBoxColumn
            // 
            this.gradeModeDataGridViewTextBoxColumn.DataPropertyName = "GradeMode";
            this.gradeModeDataGridViewTextBoxColumn.HeaderText = "GradeMode";
            this.gradeModeDataGridViewTextBoxColumn.Name = "gradeModeDataGridViewTextBoxColumn";
            // 
            // attributesDataGridViewTextBoxColumn
            // 
            this.attributesDataGridViewTextBoxColumn.DataPropertyName = "Attributes";
            this.attributesDataGridViewTextBoxColumn.HeaderText = "Attributes";
            this.attributesDataGridViewTextBoxColumn.Name = "attributesDataGridViewTextBoxColumn";
            // 
            // roomAttributesDataGridViewTextBoxColumn
            // 
            this.roomAttributesDataGridViewTextBoxColumn.DataPropertyName = "RoomAttributes";
            this.roomAttributesDataGridViewTextBoxColumn.HeaderText = "RoomAttributes";
            this.roomAttributesDataGridViewTextBoxColumn.Name = "roomAttributesDataGridViewTextBoxColumn";
            // 
            // roomCapRequestDataGridViewTextBoxColumn
            // 
            this.roomCapRequestDataGridViewTextBoxColumn.DataPropertyName = "RoomCapRequest";
            this.roomCapRequestDataGridViewTextBoxColumn.HeaderText = "RoomCapRequest";
            this.roomCapRequestDataGridViewTextBoxColumn.Name = "roomCapRequestDataGridViewTextBoxColumn";
            // 
            // crossListingsDataGridViewTextBoxColumn
            // 
            this.crossListingsDataGridViewTextBoxColumn.DataPropertyName = "CrossListings";
            this.crossListingsDataGridViewTextBoxColumn.HeaderText = "CrossListings";
            this.crossListingsDataGridViewTextBoxColumn.Name = "crossListingsDataGridViewTextBoxColumn";
            // 
            // linkToDataGridViewTextBoxColumn
            // 
            this.linkToDataGridViewTextBoxColumn.DataPropertyName = "LinkTo";
            this.linkToDataGridViewTextBoxColumn.HeaderText = "LinkTo";
            this.linkToDataGridViewTextBoxColumn.Name = "linkToDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // needsRoomDataGridViewCheckBoxColumn
            // 
            this.needsRoomDataGridViewCheckBoxColumn.DataPropertyName = "NeedsRoom";
            this.needsRoomDataGridViewCheckBoxColumn.HeaderText = "NeedsRoom";
            this.needsRoomDataGridViewCheckBoxColumn.Name = "needsRoomDataGridViewCheckBoxColumn";
            this.needsRoomDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // roomAssignmentDataGridViewTextBoxColumn
            // 
            this.roomAssignmentDataGridViewTextBoxColumn.DataPropertyName = "RoomAssignment";
            this.roomAssignmentDataGridViewTextBoxColumn.HeaderText = "RoomAssignment";
            this.roomAssignmentDataGridViewTextBoxColumn.Name = "roomAssignmentDataGridViewTextBoxColumn";
            // 
            // AmbiguityResolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 397);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AmbiguityResolver";
            this.Text = "AmbiguityResolver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingPatternDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomAttributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCapRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crossListingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn needsRoomDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomAssignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}