using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle(10, 15);
            double r1Area = r1.Area();
            Console.WriteLine($"The area of r1 is {r1Area.ToString("N1")}");

            Rectangle r2 = new Rectangle(7, 8);
            double r2Area = r2.Area();
            Console.WriteLine($"The area of r2 is {r2Area.ToString("N1")}");

           // Console.WriteLine($"The area of this rectangle is {new Rectangle(10,15).Area()}");

            Console.ReadKey();

        }
    }
}
