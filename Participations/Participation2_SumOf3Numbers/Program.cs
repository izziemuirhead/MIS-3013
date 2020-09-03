using System;

namespace Participation2_SumOf3Numbers
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number. >>");
            string response1 = Console.ReadLine();
            double numOne = Convert.ToDouble(response1);

            Console.WriteLine("Pick another number. >>");
            String response2 = Console.ReadLine();
            double numTwo = Convert.ToDouble(response2);

            Console.WriteLine("Pick another number. >>");
            String response3 = Console.ReadLine();
            double numThree = Convert.ToDouble(response3);

            double sum = (numOne + numTwo + numThree);

            Console.WriteLine("The sum of your three numbers is" + " " + sum.ToString("N3"));

            double multiplier = (sum * LUCKY_NUMBER);

            Console.WriteLine("the sum of your three numbers multiplied by the constant 7.777 is" + " " + multiplier.ToString("N3"));
            Console.ReadLine();

        }
    }
}
