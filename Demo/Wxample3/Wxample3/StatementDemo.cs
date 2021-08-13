using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxample3
{
    class StatementDemo
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập vào số thứ 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào số thứ 3: ");
            int c = int.Parse(Console.ReadLine());

            int max;

            /* cách 1
            if (max < b)
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }
            */

            //cách 2
            max = a > b ? a : b;
            max = max > c ? max : c;


            /*switch (max > b)
            {
                case true:
                    switch (max > c)
                    {
                        case false:
                            max = c;
                            break;
                    }
                    break;
                case false:
                    max = b;
                    break;
            }*/

            Console.WriteLine("Max trong 3 số {0}, {1}, {2} là {3}", a, b, c, max);

            Console.ReadKey();
        }
    }
    }

