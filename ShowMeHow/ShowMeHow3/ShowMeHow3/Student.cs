using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeHow3
{
    class Student
    {
        static void Main(string[] args)
        {
            string studentName;
            int english, maths, science;
            float percent = 0, amount = 0;
            Console.WriteLine("Enter the name of the student :");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter marks in Enghlish:");
            english = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in Maths:");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in Science:");
            science = Convert.ToInt32(Console.ReadLine());

            if ((english >= 0 && english <= 100) && (maths >= 0 && maths <= 100) && (science >= 0 && science <= 100))
            {
                if (english >= 35 && maths >= 35 && science >= 35)
                {
                    percent = ((english + maths + science) * 100) / 300;

                    if (percent > 75)
                    
                        amount = 1500;
                    
                    else if (percent >= 60 && percent <= 75)
                    
                        amount = 1000;
                    
                    else
                    
                        amount = 0;

                        Console.WriteLine("\nStudentName: " + studentName);
                        Console.WriteLine("Total Marks:" + (english + maths + science));
                        Console.WriteLine("Percentage: " + percent + "%");
                        Console.WriteLine("Scholarship Amount :" + amount + "$");
                    
                }
                else
                {
                    Console.WriteLine("\nStudentName : " + studentName);
                    Console.WriteLine("Result: Failed");
                }




            }
            else
            {
                Console.WriteLine("Invalid entry of Marks");
            }
        }
    }
}
