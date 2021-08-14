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
            if ((i != j && j != k) || (i==j&&j!=k) ||(i!=j&&j==k) || (i==k&&j!=k))
            {
               //toan tu 3 ngoi
              int  max = i > j ? i : j;   max = max > k ? max : k;
                Console.WriteLine("Max la: {0}", max);
            }
            else
            {
                Console.WriteLine("3 so bang nhau.");
            }
            Console.ReadLine();

        }
    }
}
