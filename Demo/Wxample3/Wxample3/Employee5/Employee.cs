using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxample3.Employee5
{
    class Employee
    {
        private int empID;
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
    }
    class ObjectArray
    {
        public void Run()
        {
            int[] intArray;
            Employee[] empArray ;
            intArray = new int[5];//new dung de cap phat bo nho dong cho doi tuong
             empArray = new Employee[3];

            for(int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);//
            }
            Console.WriteLine("The int array...");
            for(int i=0;i<intArray.Length;i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }

            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }



        }
        static void Main(string[] args)
        {
            ObjectArray arr = new ObjectArray();
            arr.Run();

        }
    }
}
