using System;

namespace Assignment2._2
{/// <summary>
        /// This program demonstrates the input and output operations.
        /// Class Student accepts input from the user,calculates percentage and display
        /// </summary>
        /// <remarks>Student class also demonstrates use of constants and literals.</remarks>
    class Program
    {/// <summary>
    /// The entity point for the application
    /// </summary>
    /// <param name="args">A</param>
        
        static void Main(string[] args)
        {
            const int percentConst = 100;
            string studentName;
            int english, maths, science;
            float percent = 0.0F;
            
            Console.WriteLine("Enter name of the student : ");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter marks for english:");
            english =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for maths:");
            maths= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks for science: ");
            science= Convert.ToInt32(Console.ReadLine());

            percent = ((english + maths + science) * percentConst) / 300;

            Console.WriteLine();
            Console.WriteLine("***Student Details ***");
            Console.WriteLine("Student Name: " +studentName);
            Console.WriteLine("Marks obtained in English: {0}",english);
            Console.WriteLine("Marks obtained in Maths: {0}", maths);
            Console.WriteLine("Marks obtained in Science: {0}", science);
            Console.WriteLine("Precent : {0:F2}", percent);
        }  
    }
}
