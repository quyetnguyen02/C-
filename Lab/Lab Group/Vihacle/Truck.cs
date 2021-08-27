using System;
using System.Collections.Generic;
using System.Text;

namespace Vihacle
{
    class Truck : IVihacles
    {
        float quantity;
        float lit = 1.5f;
        float distance, exist;

        public Truck() { }
        void IVihacles.display()
        {
            exist = (quantity * 0.95f) - (distance * lit);
            Console.WriteLine("consumption per km {0}" , distance * lit);
            if(exist <= 0)
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
            Console.WriteLine("Enter distance for truck: ");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity for truck: ");
            quantity = int.Parse(Console.ReadLine());
        }
    }
}
