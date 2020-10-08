using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"sales_data_sample.csv";
            string[] lines = File.ReadAllLines(filePath);

            // 0                1               2               3          4      5          6           7      8            9                           7                          8
            //ORDERNUMBER	QUANTITYORDERED	PRICEEACH	ORDERLINENUMBER	SALES	ORDERDATE	STATUS	QTR_ID	MONTH_ID	YEAR_ID	PRODUCTLINE	MSRP	PRODUCTCODE	CUSTOMERNAME	PHONE	ADDRESSLINE1	ADDRESSLINE2	CITY	STATE	POSTALCODE	COUNTRY	TERRITORY	CONTACTLASTNAME	CONTACTFIRSTNAME	DEALSIZE
            // sales(1) status(6) Month(8) year(9)

            double sum = 0;
            double sumFor2003 = 0;
            double sumFor2004 = 0;
            double sumFor2005 = 0;
            double sumForJan = 0;
            double sumForFeb = 0;
            double sumForMar = 0;
            double sumForApr = 0;
            double sumForMay = 0;
            double sumForJun = 0;
            double sumForJul = 0;
            double sumForAug = 0;
            double sumForSep = 0;
            double sumForOct = 0;
            double sumForNov = 0;
            double sumForDec = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale =  Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                int month = Convert.ToInt32(pieces[8]);

                if (pieces[6].ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumFor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumFor2004 += sale;
                    }
                    else
                    {
                        sumFor2005 += sale;
                    }

                    if (month == 1)
                    {
                        sumForJan += sale;
                    }
                    else if (month == 2)
                    {
                        sumForFeb += sale;
                    }

                    else if (month == 3)
                    {
                        sumForMar += sale;
                    }
                    else if (month == 4)
                    {
                        sumForApr += sale;
                    }
                    else if (month == 5)
                    {
                        sumForMay += sale;
                    }
                    else if (month == 6)
                    {
                        sumForJun += sale;
                    }
                    else if (month == 7)
                    {
                        sumForJul += sale;
                    }
                    else if (month == 8)
                    {
                        sumForAug += sale;
                    }
                    else if (month == 9)
                    {
                        sumForSep += sale;
                    }
                    else if (month == 10)
                    {
                        sumForOct += sale;
                    }
                    else if (month == 11)
                    {
                        sumForNov += sale;
                    }
                    else
                    {
                        sumForDec += sale;
                    }

                    sum += sale;
                }

            }

            Console.WriteLine($"The total sales of shipped items in 2003 is {sumFor2003.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in 2004 is {sumFor2004.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in 2005 is {sumFor2005.ToString("C2")}.");

            Console.WriteLine($"The total sales of shipped items in January is {sumForJan.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in February is {sumForFeb.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in March is {sumForMar.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in April is {sumForApr.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in May is {sumForMay.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in June is {sumForJun.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in July is {sumForJul.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in August is {sumForAug.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in September is {sumForSep.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in October is {sumForOct.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in November is {sumForNov.ToString("C2")}.");
            Console.WriteLine($"The total sales of shipped items in December is {sumForDec.ToString("C2")}.");

            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}.");

            Console.ReadKey();

        }
    }
}
