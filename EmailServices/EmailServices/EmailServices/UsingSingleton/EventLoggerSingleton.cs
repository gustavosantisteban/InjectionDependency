using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.UsingSingleton
{
    class EventLoggerSingleton : ILogger
    {

        private static EventLoggerSingleton instance = new EventLoggerSingleton();

        static EventLoggerSingleton()
        {

        }

        public void Log(string message)
        {
            EventLog.WriteEntry("EmailService", message);
        }
    }
}
