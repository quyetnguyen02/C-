using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxample3
{
    class StatementDemo2
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter i,j,k: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            if ((i ==j && j!=k) || (i != j && j == k) || (i != j && i == k))
            {
                if (i < k)
                {
                    Console.WriteLine("{0} max", k);
                }
                else if (i < j)
                {
                    Console.WriteLine("{0} max", j);
                }
                else
                {
                    Console.WriteLine("{0} max", i);
                }
            }/*else if(i!=j && j == k)
            {
                if (i < k)
                {
                    Console.WriteLine("{0} max", k);
                }
                else
                {
                    Console.WriteLine("{0} max", i);
                }
            }
            else if(i!=j && i == k)
            {
                if (i < j)
                {
                    Console.WriteLine("{0} max", j);
                }
                else
                {
                    Console.WriteLine("{0} max", i);
                }
            }*/
            else if(i!=j && j!=k)
            {
                if (i < k && j < k)
                {
                    Console.WriteLine("{0} max", k);
                }
                else if (i < j && j > k)
                {
                    Console.WriteLine("{0} max", j);
                }
                else
                {
                    Console.WriteLine("{0} max", i);
                }
            }
        }
    }
}
