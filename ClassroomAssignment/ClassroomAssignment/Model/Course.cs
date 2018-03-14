using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    public class Course
    {
        // Original Attributes of Supplied Spreadsheets
        public string ClassID { get; set; }
        public string SIS_ID { get; set; }
        public String Term { get; set; } 
        public string TermCode { get; set; }
        public string DepartmentCode { get; set; }
        public string SubjectCode { get; set; }
        public string CatalogNumber { get; set; }
        public string CourseName { get; set; }     // Course
        public string Section_Number { get; set; }
        public string Course_Title { get; set; }
        public string Section_Type { get; set; }
        public string Topic { get; set; }  // "Title/Topic"
        public string MeetingPattern { get; set;}
        public String Instructor { get; set; }
        public String Room { get; set; }
        public String Status { get; set; }
        public String Session { get; set; }
        public String Campus { get; set; }
        public String InstructionMethod { get; set; }
        public String IntegerPartner { get; set; }
        public String Schedule { get; set; }
        public String Consent { get; set; }
        public string CreditHrsMin { get; set; }
        public string CreditHrs { get; set; }
        public String GradeMode { get; set; }
        public String Attributes { get; set; }
        public String RoomAttributes { get; set; }
        public string Enrollment { get; set; }
        public string MaximumEnrollment { get; set; }
        public string PriorEnrollment { get; set; }
        public string ProjectedEnrollment { get; set; }
        public string WaitCap { get; set; }
        public string RoomCapRequest { get; set; }
        public String CrossListings { get; set; }
        public String LinkTo { get; set; }
        public String Comments { get; set; }
        public String Notes { get; set; }

        // Derived information
        public bool NeedsRoom { get; set; }
        public bool Meets { get; set; }
        public bool AlreadyAssignedRoom { get; set; }
        public String RoomAssignment { get; set; }
        public List<DayOfWeek> MeetingDays { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

    }
}
