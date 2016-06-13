using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityFacade security;

            security =new SecurityFacade();
            security.Activate();
            Console.WriteLine("\n-------------------\n");
            security.Deactivate();

            Console.ReadKey();

        }
    }
}
