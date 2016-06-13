using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class CoffeeSize 
    {
        protected CoffeeMate mate;

        public void AddMate(CoffeeMate mate)
        {
            this.mate = mate;
        }
        public abstract void MakeCoffee();
    }
    abstract class CoffeeMate
    {
        public abstract void MakeCoffee();
    }

    
    class JorumCoffee : CoffeeSize
    {
        public override void MakeCoffee()
        {
            Console.Write("大杯咖啡");
            mate.MakeCoffee();
        }
    }
    class MediumCoffee : CoffeeSize
    {
        public override void MakeCoffee()
        {
            Console.Write("中杯咖啡");
            mate.MakeCoffee();
        }
    }
    class SmallCoffee : CoffeeSize
    {
        public override void MakeCoffee()
        {
            Console.Write("小杯咖啡");
            mate.MakeCoffee();
        }
    }
    class Sugar : CoffeeMate
    {
        public override void MakeCoffee()
        {
            Console.WriteLine("加糖");
        }
    }
    class Milk : CoffeeMate
    {
        public override void MakeCoffee()
        {
            Console.WriteLine("加牛奶");
        }
    }
    class Lemon : CoffeeMate
    {
        public override void MakeCoffee()
        {
            Console.WriteLine("加柠檬");
        }
    }
    class None : CoffeeMate
    {
        public override void MakeCoffee()
        {
            
        }
    }
}
