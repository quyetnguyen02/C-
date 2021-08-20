using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class button : Window
    {
        public button(int top,int left) : base(top, left)
        {

        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0},{1}\n", top, left);
        }
    }
}
