using System;
using System.Net;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add all of the values from 1 to 100 and output the sum

            int sum = 0;
            // control var  condiiton   incrementation/decrementation
            for (int i = 1; i <= 100; i++)
            {
                // sum += i;
                sum = sum + i;
            }
            Console.WriteLine($"The sum of values from 1 - 100 is {sum}");

            //ask the user if they want to perform another iteration until they say no. Output number of iterations.

            int iterations = 1;
            Console.WriteLine("Do you want to perform another iteration, yes or no?");
            string response = Console.ReadLine();
            
            while (response.ToLower() == "yes")
             {
              iterations += 1;
              Console.WriteLine("Do you want to perform another iteration, yes or no?");
              response = Console.ReadLine();
            }

            Console.WriteLine($"The number of iterations (or times the user said yes) was {iterations}");
            Console.ReadKey(); // waiting for the user to press a key to exit
        }
    }
}
