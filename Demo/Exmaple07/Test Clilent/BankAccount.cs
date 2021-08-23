using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Clilent
{
    class BankAccount
    {
        public int id;
        public decimal balance;
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public static void Create(string[] cmdArgs, Dictionary<int, BankAccount> account) 
        {
            int id = int.Parse(cmdArgs[1]);
            if (account.ContainsKey(id))
            {
                Console.WriteLine("Account exist!!!");
            }
            else 
            {
                BankAccount acc = new BankAccount();
                acc.id = id;
                account.Add(id, acc);
            }
        }

        public static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> account) 
        {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!account.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist!!!");
            }
            else
            {
                account[id].Balance += amount;
            }
        }

        public static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> account) 
        {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!account.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist!!!");
            }
            else
            {
                account[id].Balance -= amount;
            }
        }

        public static void Print(string[] cmdArgs, Dictionary<int, BankAccount> account) 
        {
            int id = int.Parse(cmdArgs[1]);
            if (!account.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist!!!");
            }
            else
            {
                Console.WriteLine($"Account ID{account[id].Id}, balance {account[id].Balance}");
            }
        }
    }
}
