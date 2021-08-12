using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxample3
{
    class StatementDemo
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = 6;
            c = 7;
            if(a<=b && b >= c)
            {
                Console.WriteLine("Ds da duoc sap xep tang dan");
            }
            else if(a>=b && b >= c)
            {
                Console.WriteLine("Ds sap xep giam dan");

            }
            else
            {
                Console.WriteLine("Ds can sap xep lai");

            }
            Console.ReadLine();
        }
    }
}
