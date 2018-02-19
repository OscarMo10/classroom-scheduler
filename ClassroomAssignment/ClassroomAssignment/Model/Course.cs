using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    class Course
    {

        internal int CourseID { get; set; }
        internal int SIS_ID { get; set; }
        internal String Term { get; set; } 
        internal int TermCode { get; set; }
        internal String DepartmentCode { get; set; }
        internal String SubjectCode { get; set; }
        internal int CatalogNumber { get; set; }
        internal String Course_Label { get; set; }
        internal int Section_Number { get; set; }
        internal String Section_Type { get; set; }
        internal String Topic { get; set; }
        internal String MeetingPattern { get; set;}
        internal String Instructor { get; set; }
        internal String Room { get; set; }
        internal String Status { get; set; }
        internal String Session { get; set; }
        internal String Campus { get; set; }
        internal String InstructionMethod { get; set; }
        internal String IntegerPartner { get; set; }
        internal String ShedulePrint { get; set; }
        internal String Consent { get; set; }
        internal int CreditHrsMin { get; set; }
        internal int CreditHrs { get; set; }
        internal String GradeMode { get; set; }
        internal String Attributes { get; set; }
        internal String RoomAttributes { get; set; }
        internal int Enrollment { get; set; }
        internal int MaximumEnrollment { get; set; }
        internal int PriorEnrollment { get; set; }
        internal int WaitCap { get; set; }
        internal int RoomCapRequest { get; set; }
        internal String CrossListings { get; set; }
        internal String LinkTo { get; set; }
        internal String Comments { get; set; }
        internal String Notes { get; set; }


    }
}
