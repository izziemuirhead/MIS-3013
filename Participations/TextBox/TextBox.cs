using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor {get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }


        public TextBox()
        {
            Padding = 0;
            BackColor = ConsoleColor.Black;
            ForeColor = ConsoleColor.White;
            Text = "";
        }

        public void DisplayText()
        {
            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            string padding2 = string.Empty;
            for (int i = 0; i < Padding; i++)
            {
                padding2 = padding2 + " ";
            }
            Console.WriteLine($"{padding2} {Text} {padding2}");
        }

    }
}
