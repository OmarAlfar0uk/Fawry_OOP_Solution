using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFawry
{
    public class Cart
    {
        private List<CartItem> Items = new List<CartItem>();

        public void Add(Product product, int quantity)
        {
            if (!product.IsAvailable(quantity))
                throw new Exception($"Not enough quantity for {product.Name}.");

            Items.Add(new CartItem(product, quantity));
        }

        public void Checkout(Customer customer)
        {
            if (!Items.Any())
                throw new Exception("Cart is empty.");

            double subtotal = 0;
            double shipping = 0;
            List<IShippable> toShip = new List<IShippable>();

            foreach (var item in Items)
            {
                if (item.Product.IsExpired())
                    throw new Exception($"{item.Product.Name} is expired.");

                subtotal += item.GetTotalPrice();

                if (item.Product is IShippable shippable)
                {
                    for (int i = 0; i < item.Quantity; i++)
                        toShip.Add(shippable);
                }
            }

            shipping = toShip.Count > 0 ? 30 : 0;
            double total = subtotal + shipping;

            if (!customer.CanPay(total))
                throw new Exception("Insufficient balance.");

            // Proceed with payment and reduce product quantities
            customer.Pay(total);
            foreach (var item in Items)
                item.Product.ReduceQuantity(item.Quantity);

            // Print Shipping Info
            if (toShip.Any())
            {
                Console.WriteLine("** Shipment notice **");
                var grouped = toShip.GroupBy(p => p.GetName());
                double totalWeight = 0;

                foreach (var g in grouped)
                {
                    int count = g.Count();
                    double weight = g.First().GetWeight() * count;
                    totalWeight += weight;
                    Console.WriteLine($"{count}x {g.Key,-12} {weight * 1000}g");
                }

                Console.WriteLine($"Total package weight {totalWeight}kg\n");
            }

            // Print Receipt
            Console.WriteLine("** Checkout receipt **");
            foreach (var item in Items)
                Console.WriteLine($"{item.Quantity}x {item.Product.Name,-12} {item.GetTotalPrice()}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal         {subtotal}");
            Console.WriteLine($"Shipping         {shipping}");
            Console.WriteLine($"Amount           {total}");
            Console.WriteLine($"Remaining Balance: {customer.Balance}");
        }
    }
}
