using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle();
            IGraph anglegraph = new AngleAdapter(angle);

            anglegraph.Draw();
            Console.ReadKey();
        }
    }
}
