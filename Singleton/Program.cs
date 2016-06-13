using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class rogram
    {
        static void Main(string[] args)
        {
            Model AppConfigOne = Model.GetInstance();
            AppConfigOne.SetParameterA = "This is AppConfigOne";

            Model AppConfigTwo = Model.GetInstance();
            AppConfigTwo.SetParameterA = "This is AppConfigTwo";

            if (AppConfigOne.Equals(AppConfigTwo))
                Console.WriteLine("AppConfigOne 和 AppConfigTwo 代表的是同一个实例");
            else
                Console.WriteLine("AppConfigOne 和 AppConfigTwo 代表的不是同一个实例");

            Console.WriteLine(AppConfigOne.GetParameterA);
            Console.WriteLine(AppConfigTwo.GetParameterA);
            Console.ReadKey();
        }
    }
}
