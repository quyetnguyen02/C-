using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    class Employee:Person
    {


        public static void Create(string[] cmdArgs, Dictionary<int, Customer> account)
        {
            int id = int.Parse(cmdArgs[1]);
            if (account.ContainsKey(id))
            {
                Console.WriteLine("Account exist!!!");
            }
            else
            {
                Customer acc = new Customer();
                acc.id = id;
                account.Add(id, acc);
            }
        }

        public static void Deposit(string[] cmdArgs, Dictionary<int,Customer> account)
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
       
        
    }
}
