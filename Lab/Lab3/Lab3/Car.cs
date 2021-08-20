using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        public void Start()
        {
            System.Console.WriteLine(model + "started");
        }

        public void stop()
        {
            System.Console.WriteLine(model + "stopped");
        }

        
    }
}
