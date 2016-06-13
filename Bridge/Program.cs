using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeSize cs;
            cs = new MediumCoffee();

            cs.AddMate(new Sugar());
            cs.MakeCoffee();

            Console.ReadKey();

        }
    }

}
