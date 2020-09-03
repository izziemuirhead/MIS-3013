using System;

namespace Participation2_SumOf3Numbers
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        static void Main(string[] args)

            
        {
            double numOne = 0;
            double numTwo = 0;
            double numThree = 0;

            Console.WriteLine("Pick a number. >>");
            numOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pick another number. >>");
            numTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Pick another number. >>");
            numThree = Convert.ToDouble(Console.ReadLine());

            double sum = (numOne + numTwo + numThree);

            Console.WriteLine("The sum of your three numbers is" + " " + sum.ToString("N3"));
            Console.ReadLine();

            double product = (sum * LUCKY_NUMBER);

            Console.WriteLine("the sum of your three numbers multiplied by the constant 7.777 is" + " " + product.ToString("N3"));
            Console.ReadLine();

        }
    }
}
