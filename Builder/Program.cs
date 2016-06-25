using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder=new BMWBuilder();
            CarDirector carDirector=new CarDirector(builder);

            carDirector.CreatCar();
            Console.ReadKey();
        }
    }
}
