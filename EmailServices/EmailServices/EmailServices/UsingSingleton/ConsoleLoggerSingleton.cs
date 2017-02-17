using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices.UsingSingleton
{
    class ConsoleLoggerSingleton : ILogger
    {
        private static ConsoleLoggerSingleton instance = new ConsoleLoggerSingleton();
        
        static ConsoleLoggerSingleton()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine("{0}: {1}", DateTime.Now, message);
        }
    }
}
