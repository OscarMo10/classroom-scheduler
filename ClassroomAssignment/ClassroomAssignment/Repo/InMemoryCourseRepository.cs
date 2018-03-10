using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model.Repo
{
    class InMemoryCourseRepository : ICourseRepository
    {
        private static InMemoryCourseRepository _instance;
        public string Term { get; private set; }
        private List<Course> courses;


        public List<Course> Courses {
            get { return courses; }
            private set { courses = value; }
        }

        public static InMemoryCourseRepository getInstance()
        {
            return _instance;
        }
        public static void initInstance(string term, List<Course> courses)
        {
            _instance = new InMemoryCourseRepository(term, courses);
        }

        public InMemoryCourseRepository(string term, List<Course> courses)
        {
            Term = term;
            Courses = courses;
        }
    }
}
