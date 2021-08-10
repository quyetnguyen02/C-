using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTypes
{
    class AnonTypes
    {
        static void Main(string[] args)
        {
            var p1 = new { Name = "A", Price = 3 };
            Console.WriteLine("Name={0}\nPrice={1}", p1.Name.ToLower(), p1.Price);
            Console.ReadLine();
        }
    }
}
