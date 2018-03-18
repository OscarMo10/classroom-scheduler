using System;
using ClassroomAssignment.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.Utils
{
    [TestClass]
    public class TimeUtilTests
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestStringToTimeSpan_InvalidInput()
        {
            TimeUtil.StringToTimeSpan("");
        }

        [TestMethod]
        public void TestStringToTimeSpan_ValidInput_AM()
        {
            string timeStr = "7:30am";
            TimeSpan timeSpan = TimeUtil.StringToTimeSpan(timeStr);

            Assert.AreEqual<int>(7, timeSpan.Hours);
            Assert.AreEqual<int>(30, timeSpan.Minutes);
        }

        [TestMethod]
        public void TestStringToTimeSpan_ValidInput_PM()
        {
            string timeStr = "5:30pm";
            TimeSpan timeSpan = TimeUtil.StringToTimeSpan(timeStr);

            Assert.AreEqual<int>(17, timeSpan.Hours);
            Assert.AreEqual<int>(30, timeSpan.Minutes);
        }

        [TestMethod]
        public void TestStringToTimeSpan_Midnight()
        {
            string timeStr = "12:00am";
            TimeSpan timeSpan = TimeUtil.StringToTimeSpan(timeStr);

            Assert.AreEqual<int>(0, timeSpan.Hours);
            Assert.AreEqual<int>(0, timeSpan.Minutes);
        }

        [TestMethod]
        public void TestStringToTimeSpan_Noon()
        {
            string timeStr = "12:00pm";
            TimeSpan timeSpan = TimeUtil.StringToTimeSpan(timeStr);

            Assert.AreEqual<int>(12, timeSpan.Hours);
            Assert.AreEqual<int>(0, timeSpan.Minutes);
        }
    }
}
