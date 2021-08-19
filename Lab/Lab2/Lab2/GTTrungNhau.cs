using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class GTTrungNhau
    {
        static void Main(string[] args)
        {
            int[] Arr=new int[10] { 1,5,1,3,8,1,6,9,4,1};

            Console.WriteLine("Enter the number:");
            int a=Convert.ToInt32(Console.ReadLine());

            int dem = 0;

            for(int i = 0; i < Arr.Length; i++)
            {
                if (a == Arr[i])
                {
                    dem += 1;
                }
            }
            Console.WriteLine("A duoc lap lai {0} lan.",dem);


            
        }
    }
}
