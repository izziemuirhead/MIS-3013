using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rectangle
    {
        private int width;
        private int height;



        /// <summary>
        /// this is the defualt/empty constructor for the class.
        /// </summary>
        public Rectangle()
        {
            width = 0;
            height = 0;

        }


        /// <summary>
        /// this is the overloaded constructor passing in the starting values for width and height
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public double Area()
        {
            double result = width * height;

            return result;

        }
    }
}
