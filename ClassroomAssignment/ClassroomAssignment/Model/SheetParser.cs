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
        const int LAST_ROW_OF_HEADER = 3;
        static bool finished = false;
     

        public static List<Course> Parse(string[] filePaths)
        {
            var courses = new List<Course>();
            
            foreach (string file in filePaths)
            {
                finished = false;
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
                while(!finished)
                {
                    coursesForFile.AddRange(parseCourseRecords(csvReader));
                }
            }

            return coursesForFile;
        }

        private static List<Course> parseCourseRecords(CsvHelper.CsvReader reader)
        {

            // make sure not at header or end of file
            List<Course> courseList = new List<Course>();

            while(!(finished = !reader.Read()) && !reachedEndOfRecords(reader))
            {
                Course course = reader.GetRecord<Course>();
                courseList.Add(course);
            }

            return courseList;
        }

        static bool reachedEndOfRecords(CsvHelper.CsvReader reader)
        {
            string courseHeader = reader.GetField(0);
            string firstFieldOfRecord = reader.GetField(1);
            bool endOfRecords = !string.IsNullOrEmpty(courseHeader) || string.IsNullOrEmpty(firstFieldOfRecord);
            return endOfRecords;
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
