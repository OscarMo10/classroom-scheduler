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
        private string term;
        private List<Course> courses;

        public string Term
        {
            get { return term; }

            private set { term = value; }
        }

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
            _instance.Term = term;
            _instance.Courses = courses;
        }
    }
}
