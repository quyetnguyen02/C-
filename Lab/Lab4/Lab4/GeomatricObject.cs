using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class GeomatricObject
    {
        protected string color;
        private double weight;

        protected GeomatricObject()
        {
            color = "white";
            weight = 1.0;
        }

        protected GeomatricObject(string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }

        public string PColor
        {
            get { return color; }
            set { color = value; }
        }

        public double PWeight
        {
            get { return weight; }
            set { weight = value; }
        }

        public abstract double findArea();

        public abstract double findPerimeter();
    }
}
