using System;

namespace Identity_StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the names to be concatenated");
            Console.WriteLine("Enter first name");
            string firstText;
            firstText = Console.ReadLine();
            Console.WriteLine("Enter second name");
            string secoundText;
            secoundText = Console.ReadLine();
            string concatenatedString = firstText + " " + secoundText;
            Console.WriteLine(concatenatedString);
        }
    }
}
