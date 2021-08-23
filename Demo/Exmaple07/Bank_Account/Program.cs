using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Balance = 3000;
            Console.WriteLine($"Account{acc.Id}, Balance {acc.Balance}");
            Console.ReadLine();
        }
    }
}
