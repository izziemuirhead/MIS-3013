using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParallelCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<string> firstName = new List<string>();
            // List<string> lastName = new List<string>();
            // List<string> dobs = new List<string>();
            // List<string> favFood = new List<string>();
            // List<double> accountBalance = new List<double>();

            // firstName.Add("Izzie");
            // lastName.Add("Muirhead");
            // dobs.Add("08/16/1999");
            // favFood.Add("Pasta");
            // accountBalance.Add(600);

            // firstName.Add("Addison");
            // lastName.Add("Newman");
            // dobs.Add("09/27/1999");
            // favFood.Add("Slim Jims");
            // accountBalance.Add(1000);
            
            // for (int i = 0; i < firstName.Count; i++)
            // {
            //    Console.WriteLine($"{firstName[i]} {lastName[i]} {dobs[i]} likes {favFood[i]} and has {accountBalance[i].ToString("C")}.");
            // }

            // SAME BUT USES CLASSES

            Person Izzie = new Person();
            Izzie.fName = "Izzie";
            Izzie.lName = "Muirhead";
            Izzie.DOB = "08/16/1999";
            Izzie.favoriteFoods = "pasta";
            Izzie.acctBal = 800;

            Person Addsion = new Person("Addison", "Newman", "09/27/1999", "slim jims", 1000);
            Person Brooke = new Person("Brooke", "Roderick", "12/29/1999", "healthy food", 560);
            Person Alex = new Person("Alex", "Vinez", "03/12/2000", "gushers", 1200);
            Person Avery = new Person("Avery", "Mackie", "12/29/1999", "pizza", 450);

            Console.WriteLine(Izzie.ToString());
            Console.WriteLine(Addsion.ToString());
            Console.WriteLine(Brooke.ToString());
            Console.WriteLine(Alex.ToString());
            Console.WriteLine(Avery.ToString());

            List<Person> peeps = new List<Person>();
            peeps.Add(Izzie);
            peeps.Add(Addsion);
            peeps.Add(Brooke);
            peeps.Add(Alex);
            peeps.Add(Avery);


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
