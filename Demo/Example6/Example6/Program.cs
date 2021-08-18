using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example6
{
    class Program
    {
        
        static void Main(string[] args)
        {Class1 cl = new Class1();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[1000];
            array[0] = 20;
            array[999] = 1000;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* int a ;
             for (int i = 0; i < n; i++)
                 for(int j=i+1;j<n;j++)
             {
                 if(array[i] > array[j]){
                         a = array[i];
                         array[i] = array[j];
                         array[j] = a;
                 }
             }
             Console.WriteLine("mang sap xep tang dan:" );
             for(int i = 0; i < n; i++)
             {
                 Console.WriteLine("{0}",array[i]);
             }
            */
            cl.selectSort(array);
            

        }
    }
}
