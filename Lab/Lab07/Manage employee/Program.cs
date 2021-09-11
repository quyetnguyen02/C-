using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManage em = new EmployeeManage();
            em.Create();
            em.Display();
            em.Edit();
            em.Display();

        }
    }
}
