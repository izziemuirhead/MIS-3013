using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowernum = 0;
            int uppernum = 0;

            Console.WriteLine("You are going to guess a number between 2 values.");

            Console.WriteLine("Pick the lower number of the range.");
            lowernum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick the upper number of your range.");
            uppernum = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int num = rnd.Next(lowernum, (uppernum + 1));

            int guess = 0;

            Console.WriteLine("Guess a random number between your range.");
            guess = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Guess a random number between your range.");
                guess = Convert.ToInt32(Console.ReadLine());

            } while (guess != num);

                Console.WriteLine("You win!");

            Console.ReadKey();
        }
    }
}
