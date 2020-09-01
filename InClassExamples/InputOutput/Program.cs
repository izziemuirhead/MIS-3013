




using System;

namespace InputOutput
{
    class Program
    {
        const string CLASS_NAME = "MIS 3013";
        static void Main(string[] args)
        {
            // this wont work because it is a constant 
            //CLASS_NAME = "MIS 3353";
            //string firstName, lastName;
            string firstName = "Izzie";
            string lastName = "Muirhead";

            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine(); //getting what the user typed and storing it in th console

            Console.WriteLine("Please enter your last name >>");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your GPA? >>");
            string gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);

            Console.WriteLine(firstName + " " + lastName + " is learning "
            + CLASS_NAME  + " with a GPA of " + gpa.ToString("N1"));
        }
    }
}
