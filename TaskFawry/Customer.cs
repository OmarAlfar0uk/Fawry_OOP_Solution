using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFawry
{
    public class Customer 
    {
        public string Name { get; }
        public double Balance { get; private set; }

        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public bool CanPay(double amount) => Balance >= amount;
        public void Pay(double amount) => Balance -= amount;
    }
}
