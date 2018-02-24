using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ClassroomAssignment.Model.Utils
{
    class LogUtil
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Debug(string message)
        {
            logger.Debug(message);
        }
    }
}
