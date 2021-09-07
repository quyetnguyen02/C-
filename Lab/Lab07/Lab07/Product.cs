using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Product
    {
        string name;
        double cost;
        int onhand;
        public Product(string n,double c,int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand: {2}",name,cost,onhand);

        }
    }
}
