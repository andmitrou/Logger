using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
   public abstract class GeneralLogger
    {
         public ILog Logger { get; set; }


        public GeneralLogger(ILog logMechanism)
        {
            Logger = logMechanism;
        }

        public virtual void WriteLog(string message, LogLevel logLevel)
        {
            Logger.LogMessage(message, logLevel);
        }
    }

}
