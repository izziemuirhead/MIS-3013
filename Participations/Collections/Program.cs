using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

            double minimum = examGrades[0];
            double maximum = examGrades[0];
            double gradeSum = 0;

            for (int i = 0; i < examGrades.Count; i++)
            {
                double examGrade = examGrades[i];

                if (examGrade > minimum)
                {
                    minimum = examGrade;
                }

                if (examGrade < maximum)
                {
                    maximum = examGrade;
                }

                gradeSum = gradeSum + examGrades[i];

            }

            double gradeCount = examGrades.Count;
            double average = gradeSum / gradeCount;

            Console.WriteLine($"The minimum exam grade is {minimum}.");
            Console.WriteLine($"The maximum exam grade is {maximum}.");
            Console.WriteLine($"The average exam grade is {average}.");

            Console.ReadLine();
        }
    }
}
