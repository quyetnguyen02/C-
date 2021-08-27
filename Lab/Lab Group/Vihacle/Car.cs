using System;
using System.Collections.Generic;
using System.Text;

namespace Vihacle
{
    class Car : IVihacles
    {
        int quantity;
        float lit = 0.9f;
        float distance, exist;

        public Car() { }
        void IVihacles.display()
        {
            exist = quantity - (distance * lit);
            Console.WriteLine("consumption per km {0}", distance * lit);
            if (exist <= 0)
            {
                Console.WriteLine("The vihacle need refueling ");
            }
            else
            {
                Console.WriteLine("refuling: {0}", exist);
            }
        }

        void IVihacles.input()
        {
            Console.WriteLine("Enter distance for car: ");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity for car: ");
            quantity = int.Parse(Console.ReadLine());
        }
    }
}
