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
            string filePath = @"";

            string[] linesOfFile = File.ReadAllLines(filePath);
            int i = 0;

            foreach (var line in linesOfFile)
            {
                string[] pieces = line.Split(' ');

                if (i % 15 == 0 && i != 0)
                {
                    Console.ReadKey();
                }

                Console.WriteLine(line);
            }

            Console.WriteLine(linesOfFile);

            Console.ReadKey();
            i++;
        }

        static void ListExample()
        {
            List<string> favoriteThings = new List<string>();
            string answer;


            do
            {
                Console.WriteLine("Please enter one of your favorite things >>");
                string favoriteThing = Console.ReadLine();

                favoriteThings.Add(favoriteThing);

                Console.WriteLine("Do you have another favorite thing to tell me >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");

            Random rand = new Random();
            int index = rand.Next(0, favoriteThings.Count);

            Console.WriteLine(favoriteThings[index]);


            Console.ReadKey();

        }

        static void DictionaryExample()
        {
            Dictionary<int, double> studentGPAs = new Dictionary<int, double>();


            if (studentGPAs.ContainsKey(1) == true)
            {
                studentGPAs[1] = 1.7;
            }
            else
            {
                studentGPAs.Add(1, 1.7);
            }

            studentGPAs.Add(2, 3.5);
            studentGPAs.Add(3, 4.0);

            foreach (var studentID in studentGPAs.Keys)
            {
                Console.WriteLine(studentID);
            }


            Console.WriteLine("Please pick an ID to display the GPA of >>");
            int ID = Convert.ToInt32(Console.ReadLine());
            if (studentGPAs.ContainsKey(ID) == true)
            {
                double GPA = studentGPAs[ID];
                Console.WriteLine($"Student with ID {ID} has a GPA of {GPA}");
            }
            else
            {
                Console.WriteLine("INVALID ID GOODBYE!");
            }


            Console.ReadKey();

        }

        static void ArrayExample()
        {
            int[] studentIDs = new int[3];
            double[] studentGPA = new double[3];

            //assign values to the student ID array
            studentIDs[0] = 1;
            studentIDs[1] = 2;
            studentIDs[2] = 3;

            //assign values to the student GPA array
            studentGPA[0] = 1.75;
            studentGPA[1] = 2.99;
            studentGPA[2] = 4.0;

            foreach (int studentID in studentIDs)
            {
                Console.WriteLine(studentID);
            }

            Console.WriteLine("Please pick an ID to display the GPA of >>");
            int ID = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIDs.Length; i++)
            {
                int studentID = studentIDs[i];
                if (studentID == ID)
                {
                    double GPA = studentGPA[i];
                    Console.WriteLine($"Student with ID {ID} has a GPA of {GPA}");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
