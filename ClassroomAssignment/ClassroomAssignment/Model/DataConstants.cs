﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    public class DataConstants
    {
        public class Headers
        {
            public const string CLASS_ID = "CLSS ID";
            public const string SESSION_ID = "SIS ID";
            public const string TERM = "Term";
            public const string DEPARTMENT_CODE = "Department Code";
            public const string SUBJECT_CODE = "Subject Code";
            public const string CATALOG_NUMBER = "Catalog Number";
            public const string COURSE = "Course";
            public const string SECTION_NUM = "Section #";
            public const string COURSE_TITLE = "Course Title";
            public const string SECTION_TYPE = "Section Type";
            public const string TITLE_SLASH_TOPIC = "Title";

        }

        public class SubjectCode
        {
            public const string CSCI = "CSCI";
            public const string CSTE = "CSTE";
            public const string ISQA = "ISQA";
            public const string ITIN = "ITIN";
            public const string CIST = "CIST";
            public const string EMIT = "EMIT";
            public const string BMI = "BMI";
            public const string BIOI = "BIOI";
        }

        public class RoomOptions
        {
            public const string GENERAL_ASSIGNMENT_ROOM = "General Assignment Room";
            public const string NO_ROOM_NEEDED = "NO Room Needed";
            public const string PETER_KEIWIT_INSTITUTE_REGEX = @"Peter Keiwit Institute \d+";
        }

        public class SectionTypeOptions
        {
            public const string LECTURE = "Lecture";
            public const string INDEPENDENT_STUDY = "Independent Study";
            public const string STUDIO = "Studio";
        }

        public class MeetingPatternOptions
        {
            public const string TIME_PATTERN = @"(M|T|W|TH|F)+ (\d{1,2}:\d{1,2}am|pm)-(\d{1,2}:\d{1,2}am|pm)";
            public const string DOES_NOT_MEET = "Does Not Meet";
        }
    }
}
