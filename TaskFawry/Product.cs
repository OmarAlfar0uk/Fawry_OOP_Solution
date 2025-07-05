using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFawry
{
    public abstract class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; private set; }

        protected Product(string name, double price, int quantity)
        {
           Name = name;
            Price = price;
            Quantity = quantity;
        }

        public bool IsAvailable(int amount) => Quantity >= amount;
        public void ReduceQuantity(int amount) => Quantity -= amount;
        public abstract bool IsExpired();
        public virtual bool NeedsShipping() => false;
    }
}
