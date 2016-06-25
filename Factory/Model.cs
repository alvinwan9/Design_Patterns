using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface ILaptopFoctory
    {
        Laptop CreatLaptop();
    }

    class HPFactory : ILaptopFoctory
    {
        public Laptop CreatLaptop()
        {
            return new Hp();
        }
    }
    class AcerFactory : ILaptopFoctory
    {
        public Laptop CreatLaptop()
        {
            return new Acer();
        }
    }
    class LenovoFactory : ILaptopFoctory
    {
        public Laptop CreatLaptop()
        {
            return new Lenovo();
        }
    }
    class DellFactory : ILaptopFoctory
    {
        public Laptop CreatLaptop()
        {
            return new Dell();
        }
    }
    abstract class Laptop
    {
        public abstract void Show();
    }

    class Hp:Laptop
    {
        public override void Show()
        {
            Console.WriteLine("HP Laptop！");
        }
    }
    class Acer : Laptop
    {
        public override void Show()
        {
            Console.WriteLine("Acer Laptop！");
        }
    }
    class Lenovo : Laptop
    {
        public override void Show()
        {
            Console.WriteLine("Lenovo Laptop！");
        }
    }
    class Dell : Laptop
    {
        public override void Show()
        {
            Console.WriteLine("Dell Laptop！");
        }
    }
}
