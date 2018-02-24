using ClassroomAssignment.Model.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model.Visual
{
    class ExcelSchedulePrinter : ISchedulePrinter
    {


        static ExcelSchedulePrinter()
        {
            
        }

        public void Print(ICourseRepository courseRepo, IRoomRepository roomRepo)
        {
            throw new NotImplementedException();
        }
    }
}
