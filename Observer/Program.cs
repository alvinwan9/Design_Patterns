using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Investor gzy = new Investor("龚儿子");
            Investor mzw = new Investor("马孙子");

            Snack whh = new Snack("哇哈哈",2.0);
            whh.Attach(gzy);
            whh.Attach(mzw);

            whh.Price = 2.5;
            whh.Price = 2.0;
            whh.Price = 1.5;

            Console.ReadKey();
        }
    }
}
