using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;
using Logger.Loggers;
using System.IO;

namespace Sample
{
    class Program
    {
        static Dictionary<string, ILog> loggers;

        static void LoadLoggers()
        {
            loggers = new Dictionary<string, ILog>();
            loggers.Add("EventViewer", new EventViewerLogger());
            loggers.Add("File", new FileLogger(Path.Combine(Environment.CurrentDirectory, "log.txt")));
        }
        static void Main(string[] args)
        {
            LoadLoggers();

            //VS needs to be opened as Administrator for EventViewer.
            var logger = new ApplicationLogger(loggers["EventViewer"]);

            logger.WriteLog("Started", LogLevel.INFO);

            try
            {
                // Cause an Exception intentionally
                int age = Int32.Parse("NotNumeric");
            }
            catch (Exception ex)
            {
                logger.WriteLog(ex.Message, LogLevel.ERROR);
                logger.WriteLog("Error was thrown previously", LogLevel.WARNING);
            }


            //Now change the log mechanism to FileLogger
            logger.Logger = loggers["File"];
            logger.WriteLog("Finished", LogLevel.INFO);
        }
    }
}
