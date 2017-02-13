using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices
{
    public class EventLogger : ILogger
    {
        public void Log(string message)
        {
            EventLog.WriteEntry("EmailService", message);
        }
    }
}
