﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace ClassroomAssignment.Model
{
    public sealed class CourseClassMap : ClassMap<Course>
    {
        public CourseClassMap()
        {
            int i = 1;
            Map(m => m.ClassID).Index(i++);
            Map(m => m.SIS_ID).Index(i++);
            Map(m => m.Term).Index(i++);
            Map(m => m.TermCode).Index(i++);
            Map(m => m.DepartmentCode).Index(i++);
            Map(m => m.SubjectCode).Index(i++);
            Map(m => m.CatalogNumber).Index(i++);
            Map(m => m.CourseName).Index(i++);
            Map(m => m.Section_Number).Index(i++);
            Map(m => m.Course_Title).Index(i++);
            Map(m => m.Section_Type).Index(i++);
            Map(m => m.Topic).Index(i++);
            Map(m => m.MeetingPattern).Index(i++);
            Map(m => m.Instructor).Index(i++);
            Map(m => m.Room).Index(i++);
            Map(m => m.Status).Index(i++);
            Map(m => m.Session).Index(i++);
            Map(m => m.Campus).Index(i++);
            Map(m => m.InstructionMethod).Index(i++);
            Map(m => m.IntegerPartner).Index(i++);
            Map(m => m.Schedule).Index(i++);
            Map(m => m.Consent).Index(i++);
            Map(m => m.CreditHrsMin).Index(i++);
            Map(m => m.CreditHrs).Index(i++);
            Map(m => m.GradeMode).Index(i++);
            Map(m => m.Attributes).Index(i++);
            Map(m => m.RoomAttributes).Index(i++);
            Map(m => m.Enrollment).Index(i++);
            Map(m => m.MaximumEnrollment).Index(i++);
            Map(m => m.PriorEnrollment).Index(i++);
            Map(m => m.ProjectedEnrollment).Index(i++);
            Map(m => m.WaitCap).Index(i++);
            Map(m => m.RoomCapRequest).Index(i++);
            Map(m => m.CrossListings).Index(i++);
            Map(m => m.LinkTo).Index(i++);
            Map(m => m.Comments).Index(i++);
            Map(m => m.Notes).Index(i++);

            Map(m => m.NeedsRoom).Ignore();
            Map(m => m.AlreadyAssignedRoom).Ignore();
            Map(m => m.RoomAssignment).Ignore();
            Map(m => m.MeetingDays).Ignore();
            Map(m => m.StartTime).Ignore();
            Map(m => m.EndTime).Ignore();
        }
    }
}
