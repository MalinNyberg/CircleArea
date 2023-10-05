using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    internal class Triangle
    {
        public double Bas;
        public double Height;                       //Properties of the triangle

        public Triangle(double Bas, double Height)  //Constructor to create a triangle object
        {
            this.Bas = Bas;
            this.Height = Height;
        }

        public double GetTriangleArea()      //Method to calcuate the area of the triangle and return the area.
        { 
            double area = Bas*Height/2;
            return area;
        }
    }
}
