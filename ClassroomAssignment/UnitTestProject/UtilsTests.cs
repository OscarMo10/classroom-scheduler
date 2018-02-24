using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassroomAssignment.Model.Utils;
using System.Collections.Generic;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UtilsTests
    {
        [TestMethod]
        public void GetLongNameForDay_InvalidAbbreviation_Test()
        {
            Assert.IsNull(DateUtil.ShortToLongDayName("SS"));
        }

        [TestMethod]
        public void GetLognNameForDay_ValidAbbreviation_Test()
        {
            string expectedLongName = "Monday";
            string actualLongName = DateUtil.ShortToLongDayName("M");
            Assert.AreEqual(expectedLongName, actualLongName);
        }
    }
}
