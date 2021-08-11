using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoItYourself5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long n=1;
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0}!=: {1}", i, n = n * i);
            }
        }
    }
}
