using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
           string Birthday = Console.ReadLine();

            
            IIdentifiable identifiable = new Citizen(name, age, id,birthday);

            Console.WriteLine(identifiable.id);
        }
    }
}
