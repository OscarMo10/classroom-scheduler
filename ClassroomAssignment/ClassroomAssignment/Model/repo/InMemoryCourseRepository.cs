using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    class InMemoryCourseRepository : ICourseRepository
    {
        public string Term { get; }

        public List<Course> Courses { get; }

        public InMemoryCourseRepository(string term, List<Course> courses)
        {
            this.Term = term;
            this.Courses = courses;
        }
    }
}
