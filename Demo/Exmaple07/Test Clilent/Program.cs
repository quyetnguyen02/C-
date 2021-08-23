using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Clilent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commads = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None);

            Dictionary<int, BankAccount> account = new Dictionary<int, BankAccount>();

            while (commads[0] != "stop")
            {
                if (commads[0] == "create")
                {
                    BankAccount.Create(commads, account);
                }
                else if (commads[0] == "deposit")
                {
                    BankAccount.Deposit(commads, account);
                }
                else if (commads[0] == "withdraw")
                {
                    BankAccount.Withdraw(commads, account);
                }
                else if (commads[0] == "print")
                {
                    BankAccount.Print(commads, account);
                }
                commads = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.None);

            }
        }
    }
}
