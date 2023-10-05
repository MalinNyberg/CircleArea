using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    internal class Circle
    {
        public double radius;              //Property of the circle
        public Circle(double radius)      //constructur to create a circle objekt
        { 
            this.radius = radius;
        }

        public double GetArea()           //Method to calcuate the Area of the circle and return area.
        { 
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
