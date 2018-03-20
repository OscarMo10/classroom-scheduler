﻿namespace ClassroomAssignment.View
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
            this.components = new System.ComponentModel.Container();
            this.StartProject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sISIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.integerPartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHrsMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomAttributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumEnrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorEnrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectedEnrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCapRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crossListingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambiguousAssignmentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.needsRoomDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alreadyAssignedRoomDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomAssignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classIDDataGridViewTextBoxColumn,
            this.sISIDDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.termCodeDataGridViewTextBoxColumn,
            this.departmentCodeDataGridViewTextBoxColumn,
            this.subjectCodeDataGridViewTextBoxColumn,
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
            this.integerPartnerDataGridViewTextBoxColumn,
            this.scheduleDataGridViewTextBoxColumn,
            this.consentDataGridViewTextBoxColumn,
            this.creditHrsMinDataGridViewTextBoxColumn,
            this.creditHrsDataGridViewTextBoxColumn,
            this.gradeModeDataGridViewTextBoxColumn,
            this.attributesDataGridViewTextBoxColumn,
            this.roomAttributesDataGridViewTextBoxColumn,
            this.enrollmentDataGridViewTextBoxColumn,
            this.maximumEnrollmentDataGridViewTextBoxColumn,
            this.priorEnrollmentDataGridViewTextBoxColumn,
            this.projectedEnrollmentDataGridViewTextBoxColumn,
            this.waitCapDataGridViewTextBoxColumn,
            this.roomCapRequestDataGridViewTextBoxColumn,
            this.crossListingsDataGridViewTextBoxColumn,
            this.linkToDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.ambiguousAssignmentDataGridViewCheckBoxColumn,
            this.needsRoomDataGridViewCheckBoxColumn,
            this.alreadyAssignedRoomDataGridViewCheckBoxColumn,
            this.roomAssignmentDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
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
            // sISIDDataGridViewTextBoxColumn
            // 
            this.sISIDDataGridViewTextBoxColumn.DataPropertyName = "SIS_ID";
            this.sISIDDataGridViewTextBoxColumn.HeaderText = "SIS_ID";
            this.sISIDDataGridViewTextBoxColumn.Name = "sISIDDataGridViewTextBoxColumn";
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            // 
            // termCodeDataGridViewTextBoxColumn
            // 
            this.termCodeDataGridViewTextBoxColumn.DataPropertyName = "TermCode";
            this.termCodeDataGridViewTextBoxColumn.HeaderText = "TermCode";
            this.termCodeDataGridViewTextBoxColumn.Name = "termCodeDataGridViewTextBoxColumn";
            // 
            // departmentCodeDataGridViewTextBoxColumn
            // 
            this.departmentCodeDataGridViewTextBoxColumn.DataPropertyName = "DepartmentCode";
            this.departmentCodeDataGridViewTextBoxColumn.HeaderText = "DepartmentCode";
            this.departmentCodeDataGridViewTextBoxColumn.Name = "departmentCodeDataGridViewTextBoxColumn";
            // 
            // subjectCodeDataGridViewTextBoxColumn
            // 
            this.subjectCodeDataGridViewTextBoxColumn.DataPropertyName = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.HeaderText = "SubjectCode";
            this.subjectCodeDataGridViewTextBoxColumn.Name = "subjectCodeDataGridViewTextBoxColumn";
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
            // integerPartnerDataGridViewTextBoxColumn
            // 
            this.integerPartnerDataGridViewTextBoxColumn.DataPropertyName = "IntegerPartner";
            this.integerPartnerDataGridViewTextBoxColumn.HeaderText = "IntegerPartner";
            this.integerPartnerDataGridViewTextBoxColumn.Name = "integerPartnerDataGridViewTextBoxColumn";
            // 
            // scheduleDataGridViewTextBoxColumn
            // 
            this.scheduleDataGridViewTextBoxColumn.DataPropertyName = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.HeaderText = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.Name = "scheduleDataGridViewTextBoxColumn";
            // 
            // consentDataGridViewTextBoxColumn
            // 
            this.consentDataGridViewTextBoxColumn.DataPropertyName = "Consent";
            this.consentDataGridViewTextBoxColumn.HeaderText = "Consent";
            this.consentDataGridViewTextBoxColumn.Name = "consentDataGridViewTextBoxColumn";
            // 
            // creditHrsMinDataGridViewTextBoxColumn
            // 
            this.creditHrsMinDataGridViewTextBoxColumn.DataPropertyName = "CreditHrsMin";
            this.creditHrsMinDataGridViewTextBoxColumn.HeaderText = "CreditHrsMin";
            this.creditHrsMinDataGridViewTextBoxColumn.Name = "creditHrsMinDataGridViewTextBoxColumn";
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
            // enrollmentDataGridViewTextBoxColumn
            // 
            this.enrollmentDataGridViewTextBoxColumn.DataPropertyName = "Enrollment";
            this.enrollmentDataGridViewTextBoxColumn.HeaderText = "Enrollment";
            this.enrollmentDataGridViewTextBoxColumn.Name = "enrollmentDataGridViewTextBoxColumn";
            // 
            // maximumEnrollmentDataGridViewTextBoxColumn
            // 
            this.maximumEnrollmentDataGridViewTextBoxColumn.DataPropertyName = "MaximumEnrollment";
            this.maximumEnrollmentDataGridViewTextBoxColumn.HeaderText = "MaximumEnrollment";
            this.maximumEnrollmentDataGridViewTextBoxColumn.Name = "maximumEnrollmentDataGridViewTextBoxColumn";
            // 
            // priorEnrollmentDataGridViewTextBoxColumn
            // 
            this.priorEnrollmentDataGridViewTextBoxColumn.DataPropertyName = "PriorEnrollment";
            this.priorEnrollmentDataGridViewTextBoxColumn.HeaderText = "PriorEnrollment";
            this.priorEnrollmentDataGridViewTextBoxColumn.Name = "priorEnrollmentDataGridViewTextBoxColumn";
            // 
            // projectedEnrollmentDataGridViewTextBoxColumn
            // 
            this.projectedEnrollmentDataGridViewTextBoxColumn.DataPropertyName = "ProjectedEnrollment";
            this.projectedEnrollmentDataGridViewTextBoxColumn.HeaderText = "ProjectedEnrollment";
            this.projectedEnrollmentDataGridViewTextBoxColumn.Name = "projectedEnrollmentDataGridViewTextBoxColumn";
            // 
            // waitCapDataGridViewTextBoxColumn
            // 
            this.waitCapDataGridViewTextBoxColumn.DataPropertyName = "WaitCap";
            this.waitCapDataGridViewTextBoxColumn.HeaderText = "WaitCap";
            this.waitCapDataGridViewTextBoxColumn.Name = "waitCapDataGridViewTextBoxColumn";
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
            // ambiguousAssignmentDataGridViewCheckBoxColumn
            // 
            this.ambiguousAssignmentDataGridViewCheckBoxColumn.DataPropertyName = "AmbiguousAssignment";
            this.ambiguousAssignmentDataGridViewCheckBoxColumn.HeaderText = "AmbiguousAssignment";
            this.ambiguousAssignmentDataGridViewCheckBoxColumn.Name = "ambiguousAssignmentDataGridViewCheckBoxColumn";
            // 
            // needsRoomDataGridViewCheckBoxColumn
            // 
            this.needsRoomDataGridViewCheckBoxColumn.DataPropertyName = "NeedsRoom";
            this.needsRoomDataGridViewCheckBoxColumn.HeaderText = "NeedsRoom";
            this.needsRoomDataGridViewCheckBoxColumn.Name = "needsRoomDataGridViewCheckBoxColumn";
            this.needsRoomDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // alreadyAssignedRoomDataGridViewCheckBoxColumn
            // 
            this.alreadyAssignedRoomDataGridViewCheckBoxColumn.DataPropertyName = "AlreadyAssignedRoom";
            this.alreadyAssignedRoomDataGridViewCheckBoxColumn.HeaderText = "AlreadyAssignedRoom";
            this.alreadyAssignedRoomDataGridViewCheckBoxColumn.Name = "alreadyAssignedRoomDataGridViewCheckBoxColumn";
            // 
            // roomAssignmentDataGridViewTextBoxColumn
            // 
            this.roomAssignmentDataGridViewTextBoxColumn.DataPropertyName = "RoomAssignment";
            this.roomAssignmentDataGridViewTextBoxColumn.HeaderText = "RoomAssignment";
            this.roomAssignmentDataGridViewTextBoxColumn.Name = "roomAssignmentDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StartProject);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(390, 346);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartProject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sISIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCodeDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn integerPartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHrsMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomAttributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumEnrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorEnrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectedEnrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCapRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crossListingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ambiguousAssignmentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn needsRoomDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alreadyAssignedRoomDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomAssignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}
