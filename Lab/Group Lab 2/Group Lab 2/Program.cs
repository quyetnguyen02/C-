using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Group_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SelectedMenu sl = new SelectedMenu();
            Functions fun = new Functions();
            int userInput;
            do
            {
                 userInput = sl.DisplayMenu();
                switch (userInput)
                {
                    case 1:
                        Clear();
                        sl.MangeQuestions();
                        

                        break;

                    case 2:
                        Clear();
                        sl.MangeTest();
                      
                        break;



                }
            } while (userInput != 3);
        }
    }
}
