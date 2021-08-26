using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : ICar, IElectricCar
    {
        string name, code;
        int number;
        public Tesla()
        {
        }
        public Tesla(string name, string code, int number)
        {
            this.name = name;
            this.code = code;
            this.number = number;
        }
        public int Battery()
        {
            throw new NotImplementedException();
        }

        public string Color()
        {
            throw new NotImplementedException();
        }

        public string Model()
        {
            throw new NotImplementedException();
        }

        public string Start()
        {
            throw new NotImplementedException();
        }

        public string Stop()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
