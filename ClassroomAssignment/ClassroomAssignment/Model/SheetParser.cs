using ClassroomAssignment.Model.Repo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    public sealed class SheetParser
    {
        const int LAST_ROW_OF_HEADER = 3;
        static bool fileHasMoreRecords = true;
        private static IRoomRepository roomRepo;
     

        public static List<Course> Parse(string[] filePaths, IRoomRepository roomRepo)
        {
            SheetParser.roomRepo = roomRepo;

            var courses = new List<Course>();
            
            foreach (string file in filePaths)
            {
                fileHasMoreRecords = true;
                var coursesFromFile = parseFile(file);
                courses.AddRange(coursesFromFile);
            }

            return courses;
        }

        static List<Course> parseFile(string file)
        {
            var coursesForFile = new List<Course>();

            using (StreamReader fileStream = File.OpenText(file))
            {
                var csvReader = new CsvHelper.CsvReader(fileStream);
                
                // configure csv reader
                csvReader.Configuration.HasHeaderRecord = false;
                csvReader.Configuration.RegisterClassMap<CourseClassMap>();

                skipHeaders(csvReader);
                csvReader.Read(); // read first header
                while(fileHasMoreRecords)
                {
                    coursesForFile.AddRange(parseRecordsForCourse(csvReader));
                }
            }

            return coursesForFile;
        }

        private static List<Course> parseRecordsForCourse(CsvHelper.CsvReader reader)
        {

            // make sure not at header or end of file
            List<Course> courseList = new List<Course>();

            while((fileHasMoreRecords = reader.Read()) && courseHasMoreRecords(reader))
            {
                Course course = reader.GetRecord<Course>();
                setRoomAssignment(course);
                courseList.Add(course);
            }

            return courseList;
        }

        private static void setRoomAssignment(Course course)
        {
            Regex longPKI = new Regex(DataConstants.RoomOptions.PETER_KEIWIT_INSTITUTE_REGEX);
            Regex shortPKI = new Regex(DataConstants.RoomOptions.PKI_REGEX);

            Match roomColMatch = longPKI.Match(course.Room);
            Match commentColMatch = shortPKI.Match(course.Comments);
            Match notesColMatch = shortPKI.Match(course.Notes);

            if (!course.NeedsRoom)
            {
                course.AmbiguousAssignment = false;
                return;
            }

            // needs room but unassigned
            if(!(roomColMatch.Success || commentColMatch.Success || notesColMatch.Success))
            {
                course.AmbiguousAssignment = false;
                return;
            }

            // more than one column has room assignment
            else if (!(roomColMatch.Success ^ commentColMatch.Success ^ notesColMatch.Success))
            {
                course.AmbiguousAssignment = true;
                return;
            }

            // one column has room assignment
            if (roomColMatch.Success)
            {
                var room = roomRepo.getNormalizedRoomName(course.Room);
                course.RoomAssignment = room;
                course.AlreadyAssignedRoom = true;
            }
            else if (commentColMatch.Success)
            {
                course.RoomAssignment = course.Comments;
                course.AlreadyAssignedRoom = true;
            }
            else
            {
                course.RoomAssignment = course.Notes;
                course.AlreadyAssignedRoom = true;
            }

            return;
        }

        static bool courseHasMoreRecords(CsvHelper.CsvReader reader)
        {
            string courseHeader = reader.GetField(0);
            string firstFieldOfRecord = reader.GetField(1);
            bool hasRecordsLeft = string.IsNullOrEmpty(courseHeader) && !string.IsNullOrEmpty(firstFieldOfRecord);
            return hasRecordsLeft;
        }

        static void skipHeaders(CsvHelper.CsvReader reader)
        {
            for (int i = 0; i < LAST_ROW_OF_HEADER; i++)
            {
                reader.Read();
            }

        }
    }
}
