using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHandling2
{
    public class InvalidInput : ApplicationException
    {
        public InvalidInput() : base("Enter a number greater than zero") { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Enter anumber");
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if(intNum <= 0)
                {
                    throw new InvalidInput();
                }
            }
            catch(InvalidInput objInvalodInput)
            {
                Console.WriteLine(objInvalodInput.Message);
            }
            catch(System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    for(intCnt = 1; intCnt <= 10; intCnt++)
                    {
                        Console.WriteLine(intCnt * intNum);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
