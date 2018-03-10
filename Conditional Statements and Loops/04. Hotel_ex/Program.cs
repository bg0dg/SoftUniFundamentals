using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();

            int nights = int.Parse(Console.ReadLine());

            decimal studioPrise = 0;
            decimal doublePrise = 0;
            decimal suitePrise = 0;

            switch (month)
            {
                case "May":
                case "October": studioPrise = 50; doublePrise = 65; suitePrise = 75; break;

                case "June":
                case "September": studioPrise = 60; doublePrise = 72; suitePrise = 82; break;

                case "July":
                case "August":
                case "December": studioPrise = 68; doublePrise = 77; suitePrise = 89; break;
            }

            var studioTotalPrise = studioPrise * nights;

            var doubleTotalPrise = doublePrise * nights;

            var suiteTotalPrise = suitePrise * nights;

            if (month == "May" && nights > 7) studioTotalPrise *= 0.95M;
            else if ( (month == "June" || month == "September") && nights > 14) doubleTotalPrise *= 0.9M;
            else if ((month == "July" || month == "August" || month == "December") && nights > 14) suiteTotalPrise *= 0.85M;
            else if (month == "September" && nights > 7) studioTotalPrise = studioPrise * (nights - 1);
            else if (month == "October" && nights > 7) studioTotalPrise = studioPrise * (nights - 1) * 0.95M;

            Console.WriteLine($"Studio: {studioTotalPrise:f2} lv.");
            Console.WriteLine($"Double: {doubleTotalPrise:f2} lv.");
            Console.WriteLine($"Suite: {suiteTotalPrise:f2} lv.");

        }
    }
}
