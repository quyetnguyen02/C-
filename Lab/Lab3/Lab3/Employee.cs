using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Employee
    {

        public string firstName;
        public string lastName;
        public string adress;
       
        public double salary;

        public Employee()
        {
            firstName = firstName;
            lastName = lastName;
            adress = adress;
            
            salary = salary;



        }

        public override string ToString()
        {
            return string.Format("firstName: {0} \n lastName: {1} \n address: {3} \n salary : {4} $",firstName,lastName,adress,salary) ;
        }



        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter first name:");
            employee.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            employee.lastName = Console.ReadLine();
            Console.WriteLine("Enter address:");
            employee.adress = Console.ReadLine();
            
            Console.WriteLine("Enter salary:");
            employee.salary = Convert.ToDouble(Console.ReadLine());

            employee.ToString();

        }
    }
}
