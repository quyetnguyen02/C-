using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    class Display
    {
        public static void Print(string[] cmdArgs, Dictionary<int, Customer> account)
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
