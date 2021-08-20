using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class polymorphism
    {public static void Main(string[] args)
        {
            Window win = new Window(1, 2);
            ListBox lb = new ListBox(3, 4, "Stand alone list box");
            button b = new button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new ListBox(3, 4,"List box in array");
            winArray[2] = new button(5, 6);
            for(int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
            Console.ReadLine();
        }
    }
}
