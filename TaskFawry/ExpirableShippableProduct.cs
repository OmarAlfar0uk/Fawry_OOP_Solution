using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFawry
{
    public class ExpirableShippableProduct : Product, IShippable
    {
        public double Weight { get; }
        public DateTime ExpiryDate { get; }

        public ExpirableShippableProduct(string name, double price, int quantity, double weight, DateTime expiry)
            : base(name, price, quantity)
        {
            Weight = weight;
            ExpiryDate = expiry;
        }

        public override bool IsExpired() => DateTime.Now > ExpiryDate;
        public override bool NeedsShipping() => true;
        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
