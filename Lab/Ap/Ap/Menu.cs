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

            
            do
            {
                MenuAp();
            choose = int.Parse(ReadLine());

                switch (choose)
                {
                    case 1:
                        Clear();
                        Add();
                        break;
                    case 2:
                        Clear();
                        Display();
                        break;
                    case 3:
                        Clear();
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
        public void MenuAp()
        {
            WriteLine("1. Add product records");
            WriteLine("2. Display product records");
            WriteLine("3. Delete product by Id");
            WriteLine("4. Exit");
        }


        public void Add()
        {

            string choose;

            while (true)
            {
                Product pro = new Product();
                pro.Create();

                product.Add(pro);

                Console.WriteLine("Do You Want To Enter Next?");
                choose = Console.ReadLine();
                if (choose.Equals("N")) break;

            }

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
            int index = int.Parse(ReadLine());
           
                product.RemoveAt(index);
                WriteLine("successful delete");
            


        }
    }
}
