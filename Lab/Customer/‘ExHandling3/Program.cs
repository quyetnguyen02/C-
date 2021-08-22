using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ExHandling3
{
    class Program
    {
        public static int AnExceptionFunction(int value)
        {
            int x;
            if(value == 0)
            {
                throw new DivideByZeroException("Divide By 0 error!");}
                x = 20 / value;

                return x;
            
        }
        static void Main(string[] args)
        {
            int value = 0;
            try
            {
                value = AnExceptionFunction(10);
                    Console.WriteLine("Value = {0}", value);
                  value=  AnExceptionFunction(0);
                    Console.WriteLine("Value = {0}", value);
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Caught an exception {0}.Contiuning", ex);
            }
            Console.WriteLine("Done");
        }

    }
}
