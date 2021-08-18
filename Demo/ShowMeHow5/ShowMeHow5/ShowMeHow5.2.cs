using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeHow5
{
    class ShowMeHow2
    {
        static void Main(string[] args)
        {


            string[] colName = new string[4] { "Book Title", "Author", "publisher", "Price($)" };

            string[,] bookDetails = new string[2, 4];

            Console.WriteLine("Enter book details:\n");
            for(int i = 0; i < bookDetails.GetLength(0); i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write("{0}: ", colName[j]);
                    bookDetails[i, j] = Console.ReadLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("Details of books: \n");
            foreach(string name in colName)
            {
                Console.Write("{0}\t\t", name);
            }
            Console.WriteLine();

            for(int i = 0; i < bookDetails.GetLength(0); i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(bookDetails[i, j] + "\t");
                }
                Console.WriteLine();
            }
    }

    }
}
