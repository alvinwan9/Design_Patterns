using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class DQ
    {
        protected double price;
        public abstract double Cost();
    }
    class Icecream : DQ
    {
        private string name;

        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 10.00;
                else return price;
            }
            set { price = value; }
        }

        public Icecream(string name)
        {
            this.name = name;
        }
        public override double Cost()
        {
            Console.WriteLine("Icecream\t{0:C}", Price);
            return Price;
        }
    }
    abstract class Condiment : DQ
    {
        protected DQ component;
        public void Decorator(DQ component)
        {
            this.component = component;
        }
        public override double Cost()
        {
            if (component != null)
            {
                return component.Cost();
            }
            return 0.0;
        }
    }

    class OreoCookies : Condiment
    {
        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 2.0;
                else return price;
            }
            set { price = value; }
        }
        public override double Cost()
        {
            Console.WriteLine("Add OreoCookies\t{0:C}", Price);
            return Price + base.Cost();
        }
    }
    class Almond : Condiment
    {
        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 2.0;
                else return price;
            }
            set { price = value; }
        }
        public override double Cost()
        {
            Console.WriteLine("Add Almond\t{0:C}", Price);
            return Price + base.Cost();
        }
    }
    class Cashews : Condiment
    {
        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 2.0;
                else return price;
            }
            set { price = value; }
        }
        public override double Cost()
        {
            Console.WriteLine("Add Cashews\t{0:C}", Price);
            return Price + base.Cost();
        }
    }
    class Pecan : Condiment
    {
        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 2.0;
                else return price;
            }
            set { price = value; }
        }

        public override double Cost()
        {
            Console.WriteLine("Add Pecan\t{0:C}", Price);
            return Price + base.Cost();
        }
    }
    class Raisin : Condiment
    {
        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 2.0;
                else return price;
            }
            set { price = value; }
        }
        public override double Cost()
        {
            Console.WriteLine("Add Raisin\t{0:C}", Price);
            return Price + base.Cost();
        }
    }
    class ChocolateChip : Condiment
    {
        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 2.0;
                else return price;
            }
            set { price = value; }
        }
        public override double Cost()
        {
            Console.WriteLine("Add ChocolateChip\t{0:C}", Price);
            return Price + base.Cost();
        }
    }
    class Strawberry : Condiment
    {
        public double Price
        {
            get
            {
                if (price <= 0.0)
                    return 2.0;
                else return price;
            }
            set { price = value; }
        }
        public override double Cost()
        {
            Console.WriteLine("Add Strawberry\t{0:C}", Price);
            return Price + base.Cost();
        }
    }



}
