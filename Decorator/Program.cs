using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Icecream ice = new Icecream("甜筒");
            OreoCookies oreo = new OreoCookies();
            Cashews cashew = new Cashews();
            Strawberry strawberry = new Strawberry();

            oreo.Decorator(ice);
            cashew.Decorator(oreo);
            strawberry.Decorator(cashew);

            Console.WriteLine("The total is\t{0:C}",strawberry.Cost()) ;
            Console.ReadKey();
        }
    }
}
