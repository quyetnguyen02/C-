using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Employee
    {
        static void Main(string[] args)
        {
            int employeeID;

            string employeeName;
            string designation = "";

            DateTime birthDate;

            char gender;

            byte yearServed;

            double bonus = 0, salary = 0, taxAmount = 0, netSalary = 0;

            Console.WriteLine("Enter the ID of employee : ");
            employeeID = Convert.ToInt32(Console.ReadLine());
            if (employeeID > 0)
            {
                Console.Write("Enter the name of employee : ");
                employeeName = Console.ReadLine();
                if (employeeName != "" && employeeName.Length < 40)
                {
                    Console.WriteLine("Enter date of birth [MM/DD/YYYY] : ");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    int age = (DateTime.Today.Subtract(birthDate)).Days / 365;
                    if (age >= 18)
                    {
                         Console.Write("Enter gender [M/F] : ");
                         gender = Convert.ToChar(Console.ReadLine());

                         Console.WriteLine("Select designation (choose the number) : ");
                         Console.WriteLine("1. Manager \n2. System Analyst \n3. Developer \n4. Accountant");
                         Console.Write("Enter your choice : ");
                         int choice = Convert.ToInt32(Console.ReadLine());

                         Console.Write("Enter the tenure in years : ");
                         yearServed = Convert.ToByte(Console.ReadLine());

                         switch (choice)
                         {
                              case 1:
                                  designation = "Manager";
                                  salary = 21346;
                                  break;
                              case 2:
                                  designation = "System Analyst";
                                  salary = 16729;
                                  break;
                              case 3:
                                  designation = "Developer";
                                  salary = 14525;
                                  break;
                              case 4:
                                  designation = "Accountant";
                                  salary = 14215;
                                  break;
                          }

                        if (yearServed >= 3)
                        {
                            if (salary > 20000)
                            {
                                bonus = salary * 0.09;
                            }
                            else if (salary > 14000 && salary <= 20000)
                            {
                                bonus = salary * 0.05;
                            }
                            else
                            {
                                bonus = salary * 0.02;
                            }
                        }

                        taxAmount = salary * 33 / 100;
                        netSalary = salary - taxAmount;

                        Console.WriteLine("\nEmployee ID : " + employeeID);
                        Console.WriteLine("Employee Name : " + employeeName);
                        Console.WriteLine("Date of Birth : " + birthDate);
                        if (gender == 'M')
                            Console.WriteLine("Gender : Male");
                        else
                            Console.WriteLine("Gender : Female");
                        Console.WriteLine("Designation : " + designation);
                        Console.WriteLine("Tenure : " + yearServed);
                        Console.WriteLine("Salary : {0}", salary);
                        Console.WriteLine("Tax Amount : {0} $", taxAmount);
                        Console.WriteLine("Net Salary : {0:F2} & is rounded off to : {1} $", netSalary, (int)netSalary);
                        Console.WriteLine("Bonus : {0} $", bonus);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry for date of birth");
                    }
                 }
                 else
                 {
                     Console.WriteLine("Invalid entry for employee name");
                 }
            }
            else
            {
                Console.WriteLine("Invalid entry for employee ID");
            }
        }

    }
}

