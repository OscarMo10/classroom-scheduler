using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    public sealed class SheetParser
    {
        const int ROW_OF_FIRST_COURSE = 4;

        public static List<Course> Parse(string[] filePaths)
        {
            var courses = new List<Course>();
            
            foreach (string file in filePaths)
            {
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
                csvReader.Configuration.HasHeaderRecord = false;
                skipToFirstCourseHeader(csvReader);

                string courseHeader;
                do
                {
                    courseHeader = csvReader.GetField(0);

                    // Read actual course record
                    csvReader.Read();
                    coursesForFile.AddRange(parseCourseRecords(csvReader));
                } while (!String.IsNullOrEmpty(courseHeader));
            }

            return coursesForFile;
        }

        private static List<Course> parseCourseRecords(CsvHelper.CsvReader reader)
        {
            // make sure not at header or end of file
            List<Course> courseList = new List<Course>();
            bool done = reachedEndOfRecords(reader);
            while(!done)
            {
                Course course = reader.GetRecord<Course>();
                courseList.Add(course);
                reader.Read();
                done = reachedEndOfRecords(reader);
            }

            return courseList;
        }

        static bool reachedEndOfRecords(CsvHelper.CsvReader reader)
        {
            string courseHeader = reader.GetField(0);
            string firstFieldOfRecord = reader.GetField(1);
            bool endOfRecords = string.IsNullOrEmpty(courseHeader) && string.IsNullOrEmpty(firstFieldOfRecord);
            return endOfRecords;
        }

        static void skipToFirstCourseHeader(CsvHelper.CsvReader reader)
        {
            for (int i = 0; i < ROW_OF_FIRST_COURSE; i++)
            {
                reader.Read();
            }

        }

      
    }
}
