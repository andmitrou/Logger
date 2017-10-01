using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ApplicationLogger : GeneralLogger
    {
        public string ModuleName { get; set; }

        public ApplicationLogger(ILog logMechanism) : base(logMechanism){}

        public override void WriteLog(string message, LogLevel logLevel)
        {
            var logDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string moduleErrorMessage = String.Format("{0} : Module ({1}), Message: {2}", logDate,
                                                        ModuleName ?? "Not Specified", message);
            base.WriteLog(moduleErrorMessage, logLevel);
        }
    }
}
