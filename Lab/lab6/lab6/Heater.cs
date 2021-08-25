using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Heater
    {
        public Heater (float temperature)
        {
            temperature = temperature;
        }
        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }

        private float _Temperature;
        public void OnTemperatureChanged(float newTemperature)
        {
            if(newTemperature < Temperature)
            {
                Console.WriteLine("Heater:on");
            }
            else
            {
                Console.WriteLine("Heater:Off");
            }
        }
    }
}
