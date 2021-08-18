using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Class1
    {
        public Class1()
        {

        }
       public  void selectSort(int[] array)
        {
            int m = array.Length;
            for(int i = 0; i < m-1; i++)
            {
                int min_idx = i;
                for(int j= m + 1; j < m; j++)
                {
                    if (array[j] < array[min_idx])
                    {
                        int temp = array[min_idx];
                        array[min_idx] = array[i];
                        array[i] = temp;
                    }

                }
            }
        }
    }
}
