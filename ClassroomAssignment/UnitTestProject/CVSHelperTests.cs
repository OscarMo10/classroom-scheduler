using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassroomAssignment.Model;

namespace UnitTestProject
{
    [TestClass]
    public class CSVHelperTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var pathToMyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var pathToDataFile = Path.Combine(pathToMyDocs, "data1.csv");

            using(var textReader = File.OpenText(pathToDataFile))
            {
                var csv = new CsvHelper.CsvReader(textReader);
                csv.Read();
                csv.Read();
                csv.Read();

                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.RegisterClassMap(new CourseClassMap());
                Course c = csv.GetRecord<Course>();
            }
        }
    }
}
