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
        public int ClassID { get; set; }
        public int SIS_ID { get; set; }
        public String Term { get; set; } 
        public int TermCode { get; set; }
        public String DepartmentCode { get; set; }
        public String SubjectCode { get; set; }
        public int CatalogNumber { get; set; }
        public String Course_Label { get; set; }
        public int Section_Number { get; set; }
        public String Section_Type { get; set; }
        public String Topic { get; set; }
        public String MeetingPattern { get; set;}
        public String Instructor { get; set; }
        public String Room { get; set; }
        public String Status { get; set; }
        public String Session { get; set; }
        public String Campus { get; set; }
        public String InstructionMethod { get; set; }
        public String IntegerPartner { get; set; }
        public String SchedulePrint { get; set; }
        public String Consent { get; set; }
        public int CreditHrsMin { get; set; }
        public int CreditHrs { get; set; }
        public String GradeMode { get; set; }
        public String Attributes { get; set; }
        public String RoomAttributes { get; set; }
        public int Enrollment { get; set; }
        public int MaximumEnrollment { get; set; }
        public int PriorEnrollment { get; set; }
        public int WaitCap { get; set; }
        public int RoomCapRequest { get; set; }
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
