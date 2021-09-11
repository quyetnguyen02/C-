using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Manage_employee
{
    class Employees
    {
        public string name;
        public int age;
        public decimal salary;

        public Employees() { }

        public Employees(string name, int age,decimal salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
           
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public  void Create()
        {
            WriteLine("Enter Name: ");
            Name = ReadLine();
            WriteLine("Enter Age:");
            Age = int.Parse(ReadLine());
            WriteLine("Enter Salary:");
            Salary = decimal.Parse(ReadLine());
            

        }
        public  void DisplayEmployee()
        {
            WriteLine("Name: {0} ",Name);
            WriteLine("Age: {0}",Age);
            WriteLine("Salary:{0} $ ",Salary);
        }
        public override string ToString()
        {
            return string.Format( $"Name" + Name + "Age" + Age);
        }
        public void Edit()
        {
            WriteLine("Enter Name: ");
            Name = ReadLine();
            WriteLine("Enter Age:");
            Age = int.Parse(ReadLine());
            WriteLine("Enter Salary:");
            Salary = decimal.Parse(ReadLine());
            WriteLine("ok");

        }

    }
}
