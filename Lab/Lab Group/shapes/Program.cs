using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            Idrawable circle = new Circle(radius);


            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            Idrawable rect = new Rectangle(width, height);

            circle.Draw();

            rect.Draw();
        }
    }

  
}

