﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Model.schedule_visual
{
    public class ScheduleVisualization
    {
        private ICourseRepository CourseRepo;
        private IRoomRepository RoomRepo;
        private ISchedulePrinter Printer;

        public ScheduleVisualization(ICourseRepository courseRepo, IRoomRepository roomRepo, ISchedulePrinter printer)
        {
            CourseRepo = courseRepo;
            RoomRepo = roomRepo;
            Printer = printer;
        }

        public void PrintSchedule()
        {
                Printer.Print(CourseRepo, RoomRepo);
        }
    }
}
