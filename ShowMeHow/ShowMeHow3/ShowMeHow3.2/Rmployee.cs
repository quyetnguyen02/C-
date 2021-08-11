using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeHow3._2
{
    class Rmployee
    {
        static void Main(string[] args)
        {
            int employeeID;
            string employeeName;
            string designation;
            float taxAmount = 0;
            double salary = 0, netSalary = 0;
            Console.WriteLine("Enter the id of an eployee:");
            employeeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employeeName:");
            employeeName = Console.ReadLine();

            Console.WriteLine("Enter designation:");
            designation = Console.ReadLine();

            Console.WriteLine("Enter salary:");
            salary = Convert.ToDouble(Console.ReadLine());

            if (salary >= 10000)
            {
                taxAmount = (float)(salary * 32.5 / 100);
            }
            else
            {
                taxAmount = (float)(salary * 24.8 / 100);
            }
            netSalary = salary = taxAmount;

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Employee ID:" + employeeID);
            Console.WriteLine("Employee Name:" + employeeName);
            Console.WriteLine("Designation:" + designation);
            Console.WriteLine("Salary:", salary);
            Console.WriteLine("Net Salary : {0:F2}", netSalary);
        }
    }
}
