using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace Logger.Loggers
{
    public class EventViewerLogger : ILog
    {
        public void LogMessage(string logText, LogLevel level)
        {
            var eventViewerLevel = GetEventLogType(level);

            EventLog eventLog = new EventLog();
            eventLog.Source = Assembly.GetEntryAssembly().GetName().Name;
            eventLog.WriteEntry(logText,eventViewerLevel);
        }

        private EventLogEntryType GetEventLogType(LogLevel level)
        {
            if (level == LogLevel.ERROR)
                return EventLogEntryType.Error;
            else if (level == LogLevel.INFO)
                return EventLogEntryType.Information;
            else if (level == LogLevel.WARNING)
                return EventLogEntryType.Warning;
            else
                throw new NotSupportedException("Not known Log Level");

        }
    }
}
