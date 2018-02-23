using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    public class DepartmentSpreadSheet
    {
        public class Headers
        {
            public static string CLASS_ID = "CLSS ID";
            public static string SESSION_ID = "SIS ID";
            public static string TERM = "Term";
            public static string DEPARTMENT_CODE = "Department Code";
            public static string SUBJECT_CODE = "Subject Code";
            public static string CATALOG_NUMBER = "Catalog Number";
            public static string COURSE = "Course";
            public static string SECTION_NUM = "Section #";
            public static string COURSE_TITLE = "Course Title";
            public static string SECTION_TYPE = "Section Type";
            public static string TITLE_SLASH_TOPIC = "Title";

        }

        public class SectionTypeOptions
        {
            public static string LECTURE = "Lecture";
            public static string INDEPENDENT_STUDY = "Independent Study";
            public static string STUDIO = "Studio";
        }

        public class MeetingPatternOptions
        {
            public static string TIME_PATTERN = @"((?<daysOfWeek>(M|T|W|TH|F))+ (?<startTime>\d{1,2}:\d{1,2}(am|pm))-(?<endTime>\d{1,2}:\d{1,2}(am|pm)))";
            public static string DOES_NOT_MEET = "Does Not Meet";
        }
    }
}
