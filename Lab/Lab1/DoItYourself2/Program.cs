using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoItYourself2
{
    class SoNguyen
    {
       public int a;
       public int b;
       public int c;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SoNguyen soNguyen = new SoNguyen();
            Console.WriteLine("Enter a: ");
            soNguyen.a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            soNguyen.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            soNguyen.c = Convert.ToInt32(Console.ReadLine());
            
            if (soNguyen.a <soNguyen.b && soNguyen.c<soNguyen.b)
            {
                Console.WriteLine("Max: {0}", soNguyen.b);
            }
            else if(soNguyen.a < soNguyen.c && soNguyen.b<soNguyen.c)
            {
                Console.WriteLine("Max: {0}", soNguyen.c);

            }
            else
            {
                Console.WriteLine("Max: {0}", soNguyen.a);
            }
        }
    }
}
