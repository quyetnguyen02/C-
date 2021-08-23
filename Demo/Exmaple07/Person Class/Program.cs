using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commads = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.None);

            Dictionary<int, Customer> account = new Dictionary<int, Customer>();
            Dictionary<int, Employee> account1 = new Dictionary<int, Employee>();
            Dictionary<int, Display> account2 = new Dictionary<int, Display>();

            while (commads[0] != "stop")
            {
                if (commads[0] == "create")
                {
                   Employee.Create(commads, account);
                }
                else if (commads[0] == "deposit")
                {
                    Employee.Deposit(commads, account);
                }
                else if (commads[0] == "withdraw")
                {
                    Customer.Withdraw(commads, account);
                }
                else if (commads[0] == "print")
                {
                    Display.Print(commads, account);
                }
                commads = Console.ReadLine()
               .Split(new string[] { " " }, StringSplitOptions.None);

            }
        }
    }
}
