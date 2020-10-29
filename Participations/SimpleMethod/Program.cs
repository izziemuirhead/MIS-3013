using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            string animal = "";
            
            Console.WriteLine("Please enter an animal.");  // get animal from user
            animal = Console.ReadLine();

            string animalSound = speak(animal);  // executing the method
            Console.WriteLine(animalSound);      // displaying the correct value from the method
            Console.ReadKey();
        }

        static string speak(string animalType) // create new method with animal input from the main method
        {
            string sound = "";

            if (animalType.ToLower() == "dog") // assigning animal sounds to each animal
            {
                sound = "woof!";
            }
            else if (animalType.ToLower() == "monkey")
            {
                sound = "oo oo ahh ahh!";
            }
            else if (animalType.ToLower() == "goat")
            {
                sound = "behhhhh!";
            }
            else
            {
                sound = "cant find animal :(";
            }

            return sound;


        }
    

    }
}
