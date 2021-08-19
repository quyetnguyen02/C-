using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Copy2Mang1
    {
        static void Main(string[] args)
        {
            int[] Arr1= new int[3] { 3,6,9};
            int[] Arr2=new int[3];
            Console.WriteLine("Arr1: {0},{1},{2}",Arr1[0],Arr1[1],Arr1[2]);
            for(int i = 0; i < Arr1.Length; i++)
            {
                Arr2[i]=Arr1[i];

            }
            Console.WriteLine("Arr2: {0},{1},{2}", Arr2[0], Arr2[1], Arr2[2]);
        }
    }
}
