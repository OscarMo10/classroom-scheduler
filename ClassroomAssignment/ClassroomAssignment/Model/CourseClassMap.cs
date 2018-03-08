using System;
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
            Map(m => m.ClassID).Index(1);
            Map(m => m.SIS_ID).Index(2);
            Map(m => m.Term).Index(3);
            Map(m => m.TermCode).Index(4);
            Map(m => m.DepartmentCode).Index(5);
            Map(m => m.SubjectCode).Index(6);
            Map(m => m.CatalogNumber).Index(7);
            Map(m => m.Course_Label).Index(8);
            Map(m => m.Section_Type).Index(9);
            Map(m => m.Topic).Index(10);
            Map(m => m.MeetingPattern).Index(11);
        }
    }
}
