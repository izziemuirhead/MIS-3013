using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy Toy1 = new Toy();
            Toy1.Manufacturer = "Target";
            Toy1.Name = "Baby Doll";
            Toy1.Price = 19.99;

            Toy Toy2 = new Toy();
            Toy2.Manufacturer = "Amazon";
            Toy2.Name = "Barbie Doll";
            Toy2.Price = 24.99;

            ToyBox ToyBox1 = new ToyBox();
            ToyBox1.Toys.Add(Toy1);
            ToyBox1.Toys.Add(Toy2);

            Toy Toy3 = new Toy();
            Toy3.Manufacturer = "Toys R Us";
            Toy3.Name = "Bouncy Ball";
            Toy3.Price = 8.99;

            Toy Toy4 = new Toy();
            Toy4.Manufacturer = "Walmart";
            Toy4.Name = "Jump Rope";
            Toy4.Price = 12.99;

            ToyBox ToyBox2 = new ToyBox();
            ToyBox2.Toys.Add(Toy3);
            ToyBox2.Toys.Add(Toy4);

            Toy randomToy1 = ToyBox1.GetRandomToy();
            Toy randomToy2 = ToyBox2.GetRandomToy();

            Console.WriteLine($"{randomToy1} and is located on aisle {randomToy1.GetAisle()}.");
            Console.WriteLine($"{randomToy2} and is located on aisle {randomToy2.GetAisle()}.");



            Console.ReadKey();
        }
    }
}
