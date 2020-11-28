using System;
using System.Dynamic;

namespace Toys
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;
        private static Random rnd = new Random();

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public override string ToString()
        {
            string output = $"{Manufacturer} manufactures {Name}'s for {Price.ToString("C2")}";

            return output.ToString();
        }

        public string GetAisle()
        {
            char firstLetter = Manufacturer[0];

            int randNum = rnd.Next(1, 25);

            return $"{firstLetter}{randNum}";
        }

    }
}