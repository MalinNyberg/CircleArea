using System.Threading.Channels;

namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);    //Circle objects with a radius of 5 and 6
            Circle circle2 = new Circle(6);

            double area1 = circle1.GetArea();   //Objects to calcuate the area from circle 1 and 2.
            double area2 = circle2.GetArea();

            Console.WriteLine($"Arean av cirkel med en radie på 5 är {area1}");
            Console.WriteLine($"Arean av cirkel med en radie på 6 är {area2}");

            Triangle triangle = new Triangle(5, 7);     //triangle object with the base 5 and the height 7

            double area3 = triangle.GetTriangleArea();  //object to calcuate the area from the triangle

            Console.WriteLine($"Arean av en rätsidig triangel med basen 5 och höjden 7 är: {area3}");
        }

        
    }
}