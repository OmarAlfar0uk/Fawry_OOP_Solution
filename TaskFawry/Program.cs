namespace TaskFawry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cheese = new ExpirableShippableProduct("Cheese", 100, 5, 0.2, DateTime.Now.AddDays(3));
            var biscuits = new ExpirableShippableProduct("Biscuits", 150, 3, 0.35, DateTime.Now.AddDays(2));
            var tv = new NonExpirableShippableProduct("TV", 300, 2, 5.0);
            var scratchCard = new DigitalProduct("Scratch Card", 50, 10);

            var customer = new Customer("Omar", 500);

            var cart = new Cart();
            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);
            cart.Add(scratchCard, 1);

            cart.Checkout(customer);
        }
    }
}
