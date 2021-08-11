using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoItYourSelf1
{
    class User
    {
        public string Name;
        public string Address;
        public string Phone; 
    }
   
    class Program
    {
    
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Enter Name: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            user.Address = Console.ReadLine();
            Console.WriteLine("Enter Phone: ");
            user.Phone = Console.ReadLine();

            //Display

            Console.WriteLine("Name: {0}",user.Name);
            Console.WriteLine("Address: {0}", user.Address);
            Console.WriteLine("Phone: {0}", user.Phone);


        }
    }
}
