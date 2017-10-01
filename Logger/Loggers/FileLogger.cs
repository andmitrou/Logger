using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Loggers
{
    public class FileLogger : ILog
    {
        private string file;

        public FileLogger(string filePath)
        {           
            file = filePath;
        }

        public void LogMessage(string logText, LogLevel level)
        {
            if (String.IsNullOrEmpty(file))
                throw new NullReferenceException();

            File.WriteAllText(file, logText);
        }
    }
}
