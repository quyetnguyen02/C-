using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[12] { 29, 82, 42, 46, 54, 65, 50, 42, 5, 94, 19, 34 };
            Console.WriteLine("The  first occurrence of 42 is at index"+ Array.IndexOf(Arr,42));
            Console.WriteLine("The  last occurrence of 42 is at index" + Array.LastIndexOf(Arr, 42));

            int x = 0;
            while((x=Array.IndexOf(Arr,42,x)) >= 0)
            {

            }


        }
    }
}
