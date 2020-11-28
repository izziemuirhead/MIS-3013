using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toys
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
        }

        public Toy GetRandomToy()
        {
            Random rnd = new Random();
            int toyIndex = rnd.Next(0, Toys.Count+1);

            Toy randToy = Toys[toyIndex];

            return randToy;
        }
    }

}