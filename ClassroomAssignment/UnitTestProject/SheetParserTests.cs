﻿using ClassroomAssignment.Model;
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
        const int NUMBER_OF_PARSED_COURSES = 21;
        static List<Course> courseList;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            var debugLocation = Assembly.GetExecutingAssembly().Location;
            var debugFolder = Path.GetDirectoryName(debugLocation);
            var testFolder = Path.Combine(debugFolder, "testData");
            var files = Directory.GetFiles(testFolder);

            courseList = SheetParser.Parse(files);
        }

        [TestMethod]
        public void TestNumberOfCoursesParsed()
        {
            int actualCount = courseList.Count;
            Assert.AreEqual<int>(NUMBER_OF_PARSED_COURSES, actualCount);
        }

        [TestMethod]
        public void TestCoursePropertiesCorrect()
        {
            Course course = courseList.First();
            Assert.AreEqual<string>("3511", course.ClassID);
            Assert.AreEqual<string>("BMI 8020", course.CourseName);
            Assert.AreEqual<string>("In Person", course.InstructionMethod);
            Assert.AreEqual<string>("Graded", course.GradeMode);
            Assert.AreEqual<string>("0", course.Enrollment);
            Assert.AreEqual<string>("30", course.MaximumEnrollment);
            Assert.AreEqual<string>("30", course.RoomCapRequest);
        }

        [TestMethod]
        public void TestNumberOfUnassignedCourses()
        {
            int expectedNum = 2;
            int actualNum = courseList.FindAll(m => m.NeedsRoom && !m.AlreadyAssignedRoom).Count();
            Assert.AreEqual<int>(expectedNum, actualNum);
        }

    }
}
