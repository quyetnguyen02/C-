using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ap
{
    class Menu
    {
        List<Product> product = new List<Product>();
        static int choose;

        public void MenuMain()
        {
            WriteLine("1. Add product records");
            WriteLine("2. Display product records");
            WriteLine("3. Delete product by Id");
            WriteLine("4. Exit");
            choose = int.Parse(ReadLine());

            do
            {
                switch (choose)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        Remote(product);
                        break;
                    case 4:
                        WriteLine("Bye Bye!!");
                        break;
                    default:
                        WriteLine("chon lai!!");
                        break;
                }
            } while (choose != 4);


        }


        public void Add()
        {
            string choose;
            
            
                Product pro = new Product();
                pro.Create();

                product.Add(pro);
            WriteLine("thanh cong");

           
        }

        public void Display()
        {
            Console.WriteLine("The total number of products is: {0}", product.Count);
            foreach (var item in product)
            {
                item.Display();
            }
        }

        public void Remote(List<Product> product)
        {
            WriteLine("Enter the productI you want to delete");
            string id = ReadLine();
            foreach (var item in product)
            {
                product.RemoveAt(item.ProductID);
                WriteLine("xoa thanh cong");
            }


        }
    }
}
