using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class CarBuilder
    {
        public abstract void BuildWheel();
        public abstract void BuildOilBox();
        public abstract void BuildBody();
    }
    class BMWBuilder:CarBuilder
    {
        public override void BuildWheel()
        {
            Console.WriteLine("BMW's body!");
        }
        public override void BuildOilBox()
        {
            Console.WriteLine("BMW's OilBox!");
        }
        public override void BuildBody()
        {
            Console.WriteLine("BMW's Body!");
        }
    }
    class BenZBuilder : CarBuilder
    {
        public override void BuildWheel()
        {
            Console.WriteLine("BenZ's body!");
        }
        public override void BuildOilBox()
        {
            Console.WriteLine("BenZ's OilBox!");
        }
        public override void BuildBody()
        {
            Console.WriteLine("BenZ's Body!");
        }
    }

    class CarDirector
    {
        private CarBuilder cb;

        public void CreatCar()
        {
            cb.BuildWheel();
            cb.BuildOilBox();
            cb.BuildBody();
        }
        public CarDirector(CarBuilder cb)
        {
            this.cb = cb;
        }
    }
}
