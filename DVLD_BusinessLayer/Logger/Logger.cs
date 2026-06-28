using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_BusinessLayer
{ 
    static public class Logger
    {
        public static void LogInfo(string message)
        {
            ClsLogger.LogInfo(message);
        }

        public static void LogWarning(string message)
        {
            ClsLogger.LogWarning(message);
        }

        public static void LogError(string message, Exception ex = null)
        {
            ClsLogger.LogError(message);
        }
    }
}