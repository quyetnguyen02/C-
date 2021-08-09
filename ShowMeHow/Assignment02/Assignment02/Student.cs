using System;

namespace Assignment02
{
    class Student
    {
        static void Main(string[] args)
        {
            int studentID = 1;
            string studentName = "David George";
            byte age = 18;
            char gender = 'M';
            float percent = 75.50F;
            bool pass = true;

            Console.WriteLine("Student ID : {0}",studentID);
            Console.WriteLine("Student Name : {0}", studentName);
            Console.WriteLine("Agr : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0:F2}", percent);
            Console.WriteLine("Passed : {0}", pass);
        }
    }
}
