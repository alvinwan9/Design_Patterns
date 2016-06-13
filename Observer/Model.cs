using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IInvestor
    {
        void Update(Product product);

    }
        class Investor:IInvestor
    {
        private string name;
        private string observerState;
        private Product product;
        public Investor(string name)
        {
            this.name = name;
        }
        public void Update(Product product)
        {
            Console.WriteLine("Notified investor {0} for {1}'s change to{2:C}",name,product.Name,product.Price);
        }

        public Product Product { get; set; }
    }
    abstract class Product
    {
        protected string name;
        protected double price;
        private ArrayList investors = new ArrayList();

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public void Attach(Investor investor)
        {
            investors.Add(investor);
        }
        public void Detach(Investor investor)
        {
            investors.Remove(investor);
        }
        public void Notify()
        {
            foreach(Investor i in investors)
            {
                i.Update(this);
            }
        }
        public string Name { get{return name;} set{name=value;} }   

        public double Price
        {
            get { return price; }
            set { price = value; Notify(); }
        }
    }

    class Snack : Product
    {
        public Snack(string name, double price) : base(name, price) { }
    }

}
