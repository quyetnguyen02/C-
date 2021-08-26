using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : IDrawIble
    {
        public int width;
        public int height;
        public Rectangle() { }
        
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            DrawLine(this.width,'*','*');
            for(int i = 1; i < this.height - 1; i++)
            {
                DrawLine(this.width, ' ', '*');
            }
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width,char end, char mid)
        {
            Console.Write(end);
            for(int i = 0; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.Write(end);
        }
    }
}
