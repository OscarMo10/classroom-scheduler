using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject
{
    [TestClass]
    public class ScheduleVisualizationTests
    {
        [TestMethod]
        public void PrintCalled_Test()
        {
            Mock<ISchedulePrinter> printer = new Mock<ISchedulePrinter>();

            ScheduleVisualization scheduleVisualization = new ScheduleVisualization()
        }
    }
}
