using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Atom
    {
        public int atomicNumber;
        public string atomicSymbol;
        public string atomicName;
        public double atomicWeight;

        public Atom()
        {
            atomicNumber = atomicNumber;
            atomicSymbol = atomicSymbol;
            atomicName = atomicName;
            atomicWeight = atomicWeight;
        }
        


        public virtual void Display()
        {
            Console.WriteLine("{0}  {1}  {2}  {3}", atomicNumber, atomicSymbol, atomicName, atomicWeight);
        }

    }
}
