using System;

namespace Vihacle
{
    class Program
    {
        static void Main(string[] args)
        {
            IVihacles Cars = new Car();
            IVihacles Truck = new Truck();

            Cars.input();
            Cars.display();
            Truck.input();
            Truck.display();
        }

    }
}
