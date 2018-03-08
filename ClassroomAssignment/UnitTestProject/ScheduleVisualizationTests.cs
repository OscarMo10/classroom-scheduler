﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ClassroomAssignment.Model;
using System.Collections.Generic;
using ClassroomAssignment.Model.Repo;
using ClassroomAssignment.Model.Visual;

namespace UnitTestProject
{
    [TestClass]
    public class ScheduleVisualizationTests
    {
        Mock<ISchedulePrinter> PrinterMock = new Mock<ISchedulePrinter>();
        Mock<IRoomRepository> RoomRepoMock = new Mock<IRoomRepository>();
        Mock<ICourseRepository> CourseRepoMock = new Mock<ICourseRepository>(); 
        string Term = "Fall 2018";
        List<Course> Courses;

        [TestInitialize]
        public void Initialize()
        {
            Course testCourse = new Course();
            testCourse.ClassID = "239";
            testCourse.SIS_ID = "12615";
            testCourse.TermCode = "1188";
            testCourse.DepartmentCode = "UNO-BIOI";
            testCourse.SubjectCode = "BIOI";
            testCourse.CatalogNumber = "1000";
            testCourse.Course_Label = "BIOI 1000";
            testCourse.Section_Number = "1";
            testCourse.MeetingPattern = "MW 1:30pm-2:45pm";
            testCourse.Instructor = "Bastola, Dhundy";
            testCourse.Room = "General Assignment Room";
            testCourse.Status = "Active";
            testCourse.Session = "Regular Academic Session";
            testCourse.Campus = "UNO";
            testCourse.InstructionMethod = "In Person";
            testCourse.Comments = "PKI 153";
            testCourse.Notes = "PKI 157";
            testCourse.NeedsRoom = true;
            testCourse.AlreadyAssignedRoom = true;

            // This is the "normalized" name for the room
            testCourse.RoomAssignment = "PKI 157";
            testCourse.MeetingDays = new List<DayOfWeek>() { DayOfWeek.Monday, DayOfWeek.Wednesday };

            Courses = new List<Course>();
            Courses.Add(testCourse);
            CourseRepoMock.Setup(x => x.Courses).Returns(Courses);
            CourseRepoMock.Setup(x => x.Term).Returns(Term);
        }

        [TestMethod]
        public void PrintCalled_Test()
        {
            
            ScheduleVisualization scheduleVisualization = new ScheduleVisualization(CourseRepoMock.Object, RoomRepoMock.Object, PrinterMock.Object);
            scheduleVisualization.PrintSchedule();
            
            PrinterMock.Verify(x => x.Print(CourseRepoMock.Object, RoomRepoMock.Object));
        }
    }
}
