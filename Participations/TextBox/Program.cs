using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox textbox1 = new TextBox();
            textbox1.Padding = 8;
            textbox1.BackColor = ConsoleColor.Cyan;
            textbox1.ForeColor = ConsoleColor.Magenta;
            textbox1.Text = "Izzie Muirhead";

            textbox1.DisplayText();

            TextBox textbox2 = new TextBox();
            textbox2.Padding = 3;
            textbox2.BackColor = ConsoleColor.Yellow;
            textbox2.ForeColor = ConsoleColor.DarkBlue;
            textbox2.Text = "I love golden retrievers";

            textbox2.DisplayText();


            Console.ReadKey();
        }
    }
}
