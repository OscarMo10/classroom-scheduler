using ClassroomAssignment.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{

    [TestClass]
    public class SheetParserTests
    {
        const int NUMBER_OF_PARSED_COURSES = 22;

        [TestMethod]
        public void NumberOfCoursesParsedIsCorrect()
        {
            var debugLocation = Assembly.GetExecutingAssembly().Location;
            var debugFolder = Path.GetDirectoryName(debugLocation);
            var testFolder = Path.Combine(debugFolder, "testData");
            var files = Directory.GetFiles(testFolder);

            List<Course> courses = SheetParser.Parse(files);
            int actualCount = courses.Count;
            Assert.AreEqual<int>(0, actualCount);
        }
    }
}
