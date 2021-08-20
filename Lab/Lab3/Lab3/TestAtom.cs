using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class TestAtom
    {
       public static void Main(string[] args)
        { 
            Atom[] atom = new Atom[10];
            Console.WriteLine("Enter the Number Atom:");
                int n= Convert.ToInt32(Console.ReadLine());
            
            for( int i = 0; i < n; i++)
            {
                atom[i] = new Atom();
                Console.WriteLine("Enter atomic number:");
                atom[i].atomicNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter atomic symbol:");
                atom[i].atomicSymbol = Console.ReadLine();
                Console.WriteLine("Enter atomic name:");
                atom[i].atomicName = Console.ReadLine();
                Console.WriteLine("Enter atomic weight:");
                atom[i].atomicWeight = Convert.ToDouble(Console.ReadLine());



            }
            Console.WriteLine("-------------------------------------------------");
            for (int i = 0; i<n; i++){
                atom[i].Display();
            
            }
            Console.ReadLine();
        }
    }
}
