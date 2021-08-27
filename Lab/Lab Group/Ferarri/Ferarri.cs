using System;
using System.Collections.Generic;
using System.Text;

namespace Ferarri
{
    class Ferarri : ICar
    {
        public Ferarri() { }

        void ICar.Brakes()
        {
            Console.WriteLine("448 spider / brakes / zadu6avam sA! / Bat Giogri");
            
        }

        void ICar.Gas()
        {
            Console.WriteLine("448 spider / brakes / zadu6avam sA! / Dinko");
        }
    }
}
