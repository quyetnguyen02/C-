using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class program
    { 
        static void Main()
        {
            Car myCar;

            System.Console.WriteLine("Creating a Car object and assignning" + "its memory location to MyCar");
            myCar = new Car();

            myCar.make = "ToYoTa";
            myCar.model = "Camry";
            myCar.color = "black";
            myCar.yearBuilt = 1995;

            System.Console.WriteLine("MyCar details:");
            System.Console.WriteLine("MyCar.make = " +myCar.make);
            System.Console.WriteLine("myCar.model= " + myCar.model);
            System.Console.WriteLine("myCar.color " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt=" +myCar.yearBuilt);


            myCar.Start();
            myCar.stop();

            System.Console.WriteLine("Creating another Car object and " + "assigning its memory location to redPorsche");

            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            System.Console.WriteLine("redPorsche is a " + redPorsche.model);
            System.Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("MyCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model= " + myCar.model);
            System.Console.WriteLine("myCar.color " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt=" + myCar.yearBuilt);

            myCar = null;
            Console.ReadLine();
        }
    }
}
