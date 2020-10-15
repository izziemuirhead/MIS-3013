using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        static List<int> values = new List<int>();  // variable ourside of a method has to be static


        static void Main(string[] args)
        {

            //Random rand = new Random();     // this is an instance

            // int x;
            //  int.TryParse("cat", out x);  
            // validates that we can convert to int

            // bool isSuccess = PossiblyAddStringToAList("cat");

            // if (isSuccess == false)
            // {
            //    Console.WriteLine("Cat was not a valid integer :(");
            // }

            //isSuccess = PossiblyAddStringToAList("S");

            //Console.ReadKey();


            string answer = "";

            outputEvenNumbersFromList();
            values.AddRange(new List<int> { 5, 10, 11, 12, 13, 14, 15 });

            do
            {
                Console.WriteLine("Please enter an integer");
                string intValue = Console.ReadLine();
                bool shouldIAskAgain = PossiblyAddStringToAList(intValue);

                while (shouldIAskAgain == false)
                {
                    Console.WriteLine("Enter a valid integer this time");
                    intValue = Console.ReadLine();
                    shouldIAskAgain = PossiblyAddStringToAList(intValue);

                }

                Console.WriteLine("Do you want to enter another number");
                answer = Console.ReadLine();

            } while (answer == "yes");
        }

        /// <summary>
        /// Checks to make sure that a string is a valid integrer an if it is we will add it to the list.
        /// </summary>
        /// <param name="inputFromWhoeverCalledMe">A string that holds an integer value (hopefully)</param>
        /// <returns>
        /// true if it is able to add to the list
        /// false if it is unable to add to the list
        /// </returns>


        static bool PossiblyAddStringToAList(string inputFromWhoeverCalledMe)
        {
            bool wasSuccess = true;
            int value;

            wasSuccess = int.TryParse(inputFromWhoeverCalledMe, out value);

            if (wasSuccess)
            {
                // add to list
                values.Add(value);
            }
            else
            {
                // want to tell use they have an invalid input
                Console.WriteLine($"{inputFromWhoeverCalledMe} was not a valid integer.");
            }

            
            return wasSuccess;
        }

        static void outputEvenNumbersFromList()
        {
            Console.WriteLine("\nAll Even Values!!!\n");   // \n is enter
            for (int i = 0; i < values.Count; i++)
            {
                int currentValueInList = values[i];

                if (currentValueInList % 2 == 0)
                {
                    Console.WriteLine(currentValueInList.ToString("N0"));
                }

            }

        
        }

    

    }
}
