using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAndCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // outputting with calculation in writeline
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Length = 12;
            rectangle1.Width = 8;
            Console.WriteLine($"The area of a rectangle with a length of {rectangle1.Length} and a width of {rectangle1.Width} is {rectangle1.CalculateArea().ToString("N2")}");
            Console.WriteLine($"The perimeter of a rectangle with a length of {rectangle1.Length} and a width of {rectangle1.Width} is {rectangle1.CalculatePerimeter().ToString("N2")}");

            Console.WriteLine("\n");

            // outputting with setting variables
            Rectangle rectangle2 = new Rectangle();
            rectangle2.Length = 16;
            rectangle2.Width = 10;
            double areaOfRectangle2 = rectangle2.CalculateArea();
            double perimeterOfRectangle2 = rectangle2.CalculatePerimeter();
            Console.WriteLine($"The area of a rectangle with a length of {rectangle2.Length} and a width of {rectangle2.Width} is {areaOfRectangle2.ToString("N2")}");
            Console.WriteLine($"The perimeter of a rectangle with a length of {rectangle2.Length} and a width of {rectangle2.Width} is {perimeterOfRectangle2.ToString("N2")}");

            Console.WriteLine("\n");

            // outputting with calculation in the writeline
            Circle circle1 = new Circle();
            circle1.Radius = 7.5;
            Console.WriteLine($"The area of a circle with a radius of {circle1.Radius} is {circle1.CalculateArea().ToString("N2")}");
            Console.WriteLine($"The perimeter of a circle with a radius of {circle1.Radius} is {circle1.CalculatePerimeter().ToString("N2")}");

            Console.WriteLine("\n");

            // outputting with setting variables
            Circle circle2 = new Circle();
            circle2.Radius = 16.8;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();
            Console.WriteLine($"The area of a circle with a radius of {circle2.Radius} is {areaOfCircle2.ToString("N2")}");
            Console.WriteLine($"The perimeter of a circle with a radius of {circle2.Radius} is {perimeterOfCircle2.ToString("N2")}");

            // Circle circle3 = new Circle(3.5);
            // anoter way to set the radius

            Console.ReadKey();
        }
    }
}
