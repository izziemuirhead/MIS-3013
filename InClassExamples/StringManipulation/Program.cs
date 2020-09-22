using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //                         012345678910
            string instanceOfString = "Hello World!";

            instanceOfString = instanceOfString.ToUpper();

            for (int i = 0; i < instanceOfString.Length; i++)
            {
                char letter = instanceOfString[i];
                //have to convert the character to a string to use the upper function
                Console.WriteLine(letter);
            }


            Console.ReadKey();

        }
    }
}
