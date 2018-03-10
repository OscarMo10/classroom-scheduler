using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual("M", MeetingTimeMatch.Groups["daysOfWeek"].Captures[0].Value);
            Assert.AreEqual("T", MeetingTimeMatch.Groups["daysOfWeek"].Captures[1].Value);
            Assert.AreEqual("5:30pm", MeetingTimeMatch.Groups["startTime"].Value);
            Assert.AreEqual("8:10pm", MeetingTimeMatch.Groups["endTime"].Value);
        }
    }
}
