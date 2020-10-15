using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharToInt
{
    class Program
    {
        static void Main(string[] args)
        {

            char letter = '8';
            string letterString = letter.ToString();
            int number = Convert.ToInt32(letterString);
            Console.WriteLine(number);

            Console.ReadKey();

        }
    }
}
