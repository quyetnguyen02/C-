using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
   public class Circle : GeomatricObject
    {
        private double radius;
        public Circle(double x)
        {
            this.radius = x;
        }

        public Circle(double x,string c,double w) : base(c, w)
        {
            this.radius = x;
        }

        public override string ToString()
        {
            return "Circle has:radius" + radius + ",color is" + PColor +"Weight is" + PWeight;
        }

        public override double findArea()
        {
            return Math.PI*radius*radius;
        }

        public override double findPerimeter()
        {
            return 2* Math.PI * radius;
        }
    }
    
    }

