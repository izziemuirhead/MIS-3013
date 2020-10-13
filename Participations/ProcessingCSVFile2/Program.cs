using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingCSVFile2
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"SalesJan2009.csv";
            string[] lines = File.ReadAllLines(filePath); //collection of strings


            // 0                1        2        3              4       5        6      7       8               9           10            11               
            //Transaction_date	Product	Price	Payment_Type	Name	City	State	Country	Account_Created	Last_Login	Latitude	Longitude


            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                string name = pieces[4];
                string transactionDate = pieces[0];

                if (pieces[3].ToLower() == "visa" && pieces[7].ToLower() == "united states")
                {
                    Console.WriteLine($"{name}, {transactionDate}");
                }
            }


            Console.ReadKey();
        }
    }
}
