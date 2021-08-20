using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Window
    {
        public Window(int top,int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing window at {0},{1}", top, left);
        }

        protected int top;
        protected int left;
    }
}
