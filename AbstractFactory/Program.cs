using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new McDonalds();
            Snack McHamburg = f.MakeHamburg();
            McHamburg.SnackInfo();
            Snack McCola = f.MakeCola();
            McCola.SnackInfo();

            f = new KFC();
            Snack KFCHamburg = f.MakeHamburg();
            KFCHamburg.SnackInfo();
            Snack KFCCola = f.MakeCola();
            KFCCola.SnackInfo();

            Console.ReadKey();
            
        }
    }
    abstract class Snack
    {
        public abstract void SnackInfo();
    }
    class McHamburg:Snack
    {
        public override void SnackInfo()
        {
            Console.WriteLine("This is McHamburg!");
        }
    }
    class McCola : Snack
    {
        public override void SnackInfo()
        {
            Console.WriteLine("This is McCola!");
        }
    }
    class KFCHamburg : Snack
    {
        public override void SnackInfo()
        {
            Console.WriteLine("This is KFCHamburg!");
        }
    }
    class KFCCola : Snack
    {
        public override void SnackInfo()
        {
            Console.WriteLine("This is KFCCola!");
        }
    }
    abstract class Factory
    {
        public abstract Snack MakeHamburg();
        public abstract Snack MakeCola();
    }
    class McDonalds : Factory
    {
        public override Snack MakeHamburg()
        {
            return new McHamburg();
        }
        public override Snack MakeCola()
        {
            return new McCola();
        }
    }
    class KFC : Factory
    {
        public override Snack MakeHamburg()
        {
            return new KFCHamburg();
        }
        public override Snack MakeCola()
        {
            return new KFCCola();
        }
    }
}
