using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations ma = new MathOperations();
          Console.WriteLine(  ma.Add(2,3));
            Console.WriteLine(ma.Add(2.2, 3.3,5.5));
            Console.WriteLine(ma.Add(2.2m, 3.3m,4.4m));

        }
    }
}
