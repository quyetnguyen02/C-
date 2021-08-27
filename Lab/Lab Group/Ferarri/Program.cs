using System;

namespace Ferarri
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Ferarri();
            car.Brakes();
            car.Gas();
        }
    }
}
