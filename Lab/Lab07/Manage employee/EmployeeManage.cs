using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Manage_employee
{
    class EmployeeManage
    {   ArrayList inv = new ArrayList();
        public  void Create() {

            Employees emp = new Employees();
            emp.Create();
           inv.Add(new Employees(emp.Name,emp.Age,emp.Salary));
            WriteLine("ok");
           
        }
        public  void Display()
        {
             foreach(Employees i in inv)
            {
                i.DisplayEmployee();
            }
            

        }
        public void Edit()
        {
            Employees emp = new Employees();
            WriteLine("enter the name you want to romove");
            string name = ReadLine();
            if (inv.))
            {
               // emp.Edit();
                inv.Remove(emp.Name);
            }
            else
            {
                WriteLine("deo tim thay");
            }
        }




    }
}
