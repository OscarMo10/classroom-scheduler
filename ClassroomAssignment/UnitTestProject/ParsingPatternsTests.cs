﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using ClassroomAssignment.Model;

namespace UnitTestProject
{
    [TestClass]
    public class ParsingPatternsTests
    {
        private Match MeetingTimeMatch;

        [TestInitialize]
        public void Initialize()
        {
            MeetingTimeMatch = Regex.Match("MT 5:30pm-8:10pm", DataConstants.MeetingPatternOptions.TIME_PATTERN);
        }

        [TestMethod]
        public void Test_MeetingPatternMatches()
        {
            Assert.IsTrue(MeetingTimeMatch.Success, "Meeting Pattern does not match.");
        }

        [TestMethod]
        public void Test_PatternGroupsMatch()
        {
            // days of week
            var startTime = MeetingTimeMatch.Groups[2].Value;
            Assert.AreEqual<string>("5:30pm", startTime);

            var endTime = MeetingTimeMatch.Groups[3].Value;
            Assert.AreEqual<string>("8:10pm", endTime);
        }
    }
}
