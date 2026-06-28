using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class ClsLogger
    {
        private const string LogName = "DVLD Logs";
        private const string SourceName = "DVLD";

        static ClsLogger()
        {
            Initialize();
        }

        private static void Initialize()
        {
            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, LogName);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[Logger Init Failed]: {ex.Message}");
            }
        }

        public static void LogInfo(string message)
        {
            BuildAndWriteLog(message, EventLogEntryType.Information, null);
        }

        public static void LogWarning(string message)
        {
            BuildAndWriteLog(message, EventLogEntryType.Warning, null);
        }

        public static void LogError(string message, Exception ex = null)
        {
            BuildAndWriteLog(message, EventLogEntryType.Error, ex);
        }

        private static void BuildAndWriteLog(string userMessage, EventLogEntryType type, Exception ex)
        {
            StackTrace stackTrace = new StackTrace(2, true);
            StackFrame frame = stackTrace.GetFrame(0);

            MethodBase callingMethod = frame?.GetMethod();
            string className = callingMethod?.DeclaringType?.FullName ?? "UnknownClass";
            string methodName = callingMethod?.Name ?? "UnknownMethod";


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==================================================");
            sb.AppendLine($"[Location] Class: {className} -> Method: {methodName}");
            sb.AppendLine($"[Message]  {userMessage}");

            if (ex != null)
            {
                sb.AppendLine($"[Exception] {ex.Message}");
                sb.AppendLine($"[Stack Trace] {ex.StackTrace}");
            }
            sb.AppendLine("==================================================");

            WriteLog(sb.ToString(), type);
        }

        private static void WriteLog(string message, EventLogEntryType type)
        {
            try
            {
                if (EventLog.SourceExists(SourceName))
                {
                    EventLog.WriteEntry(SourceName, message, type);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}