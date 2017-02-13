using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServices
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var kernel = new StandardKernel())
            {
                kernel.Bind<ILogger>().To<ConsoleLogger>();
                var emailService = kernel.Get<Services.EmailService>();
                emailService.SendEmail("algunemailparaenviar@gmail.com", "Hola Mundo", "Cracks de los Hola Mundos");
            }
        }
    }
}
