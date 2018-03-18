using ClassroomAssignment.Model.Utils;
using ClassroomAssignment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ClassroomAssignment.Model.DataConstants;

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

        private string _meetingPattern;
        public string MeetingPattern
        {
            get { return _meetingPattern; }

            set
            {
                Regex regex = new Regex(DataConstants.MeetingPatternOptions.TIME_PATTERN);
                Match match = regex.Match(value);

                if (match.Success)
                {
                    var daysCapture = match.Groups[1].Captures;
                    MeetingDays = new List<DayOfWeek>();
                    foreach(Capture c in daysCapture)
                    {
                        DayOfWeek day = DateUtil.AbbreviationToDayOfWeek(c.Value);
                        MeetingDays.Add(day);
                    }

                    var startTimeStr = match.Groups[2].Value;
                    StartTime = TimeUtil.StringToTimeSpan(startTimeStr);
                    var endTimeStr = match.Groups[3].Value;
                    EndTime = TimeUtil.StringToTimeSpan(endTimeStr);
                }

                _meetingPattern = value;
            }
        
        }

        public string Instructor { get; set; }

        public string Room { get; set; }

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
        public bool AmbiguousAssignment { get; set; }

        private bool? _needsRoom;
        public bool NeedsRoom
        {
            get
            {
                if (_needsRoom.HasValue) return _needsRoom.Value;

                if (InstructionMethod.Equals(InstructionMethods.OFF_CAMPUS))
                {
                    _needsRoom = false;
                    return _needsRoom.Value;
                }

                switch (Room)
                {
                    case RoomOptions.GENERAL_ASSIGNMENT_ROOM:
                        _needsRoom = true;
                        break;
                    case RoomOptions.ROOM_ASSIGNMENT_PENDING:
                        _needsRoom = true;
                        break;
                    case RoomOptions.NO_ROOM_NEEDED:
                        _needsRoom = false;
                        break;
                }

                if (_needsRoom.HasValue) return _needsRoom.Value;

                Regex pkiLongName = new Regex(RoomOptions.PETER_KEIWIT_INSTITUTE_REGEX);
                
                Match m = pkiLongName.Match(Room);
                if (m.Success)
                {
                    _needsRoom = true;
                }
                else
                {
                    _needsRoom = false;
                }

                return _needsRoom.Value;
            }
        }



        public bool AlreadyAssignedRoom { get; set; }

        public string RoomAssignment { get; set; }
        public List<DayOfWeek> MeetingDays { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

    }
}
