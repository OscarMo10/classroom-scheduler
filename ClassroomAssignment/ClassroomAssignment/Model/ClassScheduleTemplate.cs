﻿using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ClassroomAssignment.Model
{
    public static class ClassScheduleTemplate
    {
        public const string SCHEDULE_TEMPLATE_NAME = "ScheduleTemplate";
        private static OrderedDictionary subjectColorMap = new OrderedDictionary();

        static ClassScheduleTemplate()
        {
            subjectColorMap.Add(DataConstants.SubjectCode.BIOI, IndexedColors.LightTurquoise.Index);
            subjectColorMap.Add(DataConstants.SubjectCode.BMI, IndexedColors.LightGreen.Index);
            subjectColorMap.Add(DataConstants.SubjectCode.CIST, IndexedColors.LightBlue.Index);
            subjectColorMap.Add(DataConstants.SubjectCode.CSCI, IndexedColors.LightOrange.Index);
            subjectColorMap.Add(DataConstants.SubjectCode.CSTE, IndexedColors.LightYellow.Index);
            subjectColorMap.Add(DataConstants.SubjectCode.EMIT, IndexedColors.Lime.Index);
            subjectColorMap.Add(DataConstants.SubjectCode.ISQA, IndexedColors.Rose.Index);
            subjectColorMap.Add(DataConstants.SubjectCode.ITIN, IndexedColors.Teal.Index);
        }

        public static ICellStyle GetCellStyle(IWorkbook workbook, short foregroundColor)
        {
            IFont font = workbook.CreateFont();
            font.Boldweight = (short) FontBoldWeight.Normal;
            font.FontName = "Calibri";
            font.FontHeightInPoints = 11;

            ICellStyle style = workbook.CreateCellStyle();
            style.SetFont(font);
            style.WrapText = true;
            style.VerticalAlignment = VerticalAlignment.Center;
            style.Alignment = HorizontalAlignment.Center;
            style.FillForegroundColor = foregroundColor;
            style.FillPattern = FillPattern.SolidForeground;
            return style;
        }

        public static short Color(this Course course)
        {
            switch(course.SubjectCode)
            {
                case DataConstants.SubjectCode.BIOI:
                    return (short)subjectColorMap[DataConstants.SubjectCode.BIOI];
                default:
                    return (short)IndexedColors.SeaGreen.Index;
            }
        }

        public static OrderedDictionary GetSubjectColorMap()
        {
            return subjectColorMap;
        }
    }
}
