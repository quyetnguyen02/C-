using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class GopMang
    {
        static void Main(string[] args)
        {
            int[] Arr1=new int[5] ;
            int[] Arr2 = new int[5] ;
            int[] Arr3 = new int[10];

          
            for(int i = 0; i < Arr1.Length; i++)
            {
                Arr3[i]= Arr1[i];
               
               
            }
            for (int i = 0; i < Arr2.Length; i++)
            {
               
                Arr3[i] = Arr2[i];
                i++;
            }
           
            foreach(int a in Arr3)
            {
                Console.WriteLine(a);
            }
        }
    }
}
