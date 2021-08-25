using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    class Customer : Person
    {
        string address;
        decimal balance;
        public string Address { get; set; }
        public decimal Balance { get; set; }

       

        public static void Withdraw(string[] cmdArgs, Dictionary<int,Customer> account)
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
    }
}
