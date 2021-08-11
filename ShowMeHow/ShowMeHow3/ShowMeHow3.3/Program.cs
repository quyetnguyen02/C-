using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeHow3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Object objProductID;
            Object objProductName;
            Object objPrice;
            Object objQuantity;

            Console.Write("Enter the id of product:");
            objProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the id of productName:");
            objProductName =Console.ReadLine();

            Console.Write("Enter  ofPrice:");
            objPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity:");
            objQuantity = Convert.ToInt32(Console.ReadLine());

            int productID = (int)objProductID;
            string productname = (string)objProductName;
            double price = (double)objPrice;
            int quantity = (int)objQuantity;
            double amtPayable = (int)objQuantity * price;
            Console.WriteLine("\nProdcut Details:");
            Console.WriteLine("ProductID :" + productID);
            Console.WriteLine("Productname :" + productname);
            Console.WriteLine("Price :" + price);
            Console.WriteLine("Quantity :" + quantity);
            Console.WriteLine("AmtPayable :" + amtPayable);

        }
    }
}
