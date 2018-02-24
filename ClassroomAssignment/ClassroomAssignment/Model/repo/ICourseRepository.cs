using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model
{
    public interface ICourseRepository
    {
        string Term { get; }
        List<Course> Courses { get; }
    }
}
