using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFawry
{
    internal class NonExpirableShippableProduct : Product, IShippable
    {
        public double Weight { get; }

        public NonExpirableShippableProduct(string name, double price, int quantity, double weight)
            : base(name, price, quantity)
        {
            Weight = weight;
        }

        public override bool IsExpired() => false;
        public override bool NeedsShipping() => true;
        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
