using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ap
{
    class Product
    {
        int productId;
        string productName;
        decimal price;
        public Product() { }

        public Product(int productId, string productName, decimal price )
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;

        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public void Create()
        {
            WriteLine("Enter ProductID: ");
            ProductID = int.Parse(ReadLine());
            WriteLine("Enter ProductName: ");
            ProductName = ReadLine();
            WriteLine("Enter Price: ");
            Price = decimal.Parse(ReadLine());



        }

        public void Display()
        {
            WriteLine("ProductID: {0}", ProductID);
            WriteLine("ProductName:{0} ", ProductName);
            WriteLine("Price:{0} ", Price);
            WriteLine("---------------------");

        }

    }
}
