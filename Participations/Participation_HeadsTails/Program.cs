using System;

namespace Participation_HeadsTails
{
    class Program
    {
        const string DEVELOPER_NAME = "Isabelle Muirhead";
        static void Main(string[] args)
        {
            Console.WriteLine("Pick heads or tails.");
            string response = Console.ReadLine();
            
            Random rnd = new Random();
            int num = rnd.Next(1, 3);

            if (num == 1)
            {
                Console.WriteLine("Heads!");
            }
            else
            {
                Console.WriteLine("Tails!");
            }
            if ((num == 1) && (response == "heads"))
            {
                Console.WriteLine("You win!!!!");
            }
            else if ((num == 2) && (response == "tails"))
            {
                Console.WriteLine("You win!!!!");
            }
            else
            {
                Console.WriteLine("You lose!!!!");
            }
            Console.ReadLine();

            Console.WriteLine(DEVELOPER_NAME);
        }
    }
}
