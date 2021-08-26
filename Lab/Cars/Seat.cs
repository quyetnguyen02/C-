using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Seat : ICar
    {
        string name;
        string code;
        public Seat()
        {
        }
        public Seat(string name, string code)
        {
            this.name = name;
            this.code = code;
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
