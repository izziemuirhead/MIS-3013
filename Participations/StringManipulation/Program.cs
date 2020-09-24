using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = ("Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            Console.WriteLine(statement);
            Console.ReadLine();

            Console.WriteLine("Which word in this sentence would you like to look up?");
            string lookup = Console.ReadLine();
            Console.WriteLine("Which word in this sentence would you like to replace?");
            string replacement = Console.ReadLine();

            bool check = statement.Contains(lookup);

            if (check == false)
            {
                Console.WriteLine($"Sorry, I could not find your word {lookup}");

                for (int i = lookup.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(lookup[i]);
                   
                }
            }
            else
            {
                string newProg = statement.Replace(lookup, replacement);
                Console.WriteLine(newProg);
            }
               
            
            Console.ReadKey();
        }
    }
}
