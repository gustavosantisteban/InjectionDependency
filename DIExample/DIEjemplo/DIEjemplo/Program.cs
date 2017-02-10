using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
namespace DIEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var kernel = new StandardKernel())
            {
                var service = kernel.Get<Bienvenida>();
                service.Saludo();
                Console.ReadLine();
            }
        }
    }
}
