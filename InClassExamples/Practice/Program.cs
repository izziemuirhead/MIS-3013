using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 1;
            string response = "";

            do
            {
                Console.WriteLine("Do you want to enter a number?");
                response = Console.ReadLine();
                number+=1;

            } while (response == "yes");

            Console.WriteLine(number);

            Console.ReadKey();

        }
    }
}
