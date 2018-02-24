﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model.schedule_visual
{
    public interface ISchedulePrinter
    {
        void Print(ICourseRepository courseRepo, IRoomRepository roomRepo);
    }
}
