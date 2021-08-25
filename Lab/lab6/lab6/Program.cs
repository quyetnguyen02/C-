using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {


        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChange += heaterCuong.OnTemperatureChanged;


            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;


            string temperature;
            Console.Write("Wnter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.WriteLine();



        }
    }
}


