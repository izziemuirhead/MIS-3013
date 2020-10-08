using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrades = new List<double>();
            string answer;

            do
            {
                Console.WriteLine("Please enter your exam grade >>");
                double examGrade = Convert.ToDouble(Console.ReadLine());

                examGrades.Add(examGrade);

                Console.WriteLine("Do you have another exam grade to enter? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            double maximum = 0;
            double minimum = 0;
            double average = 0;


            Console.ReadLine();
        }
    }
}
