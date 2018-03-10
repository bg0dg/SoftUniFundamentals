using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());

            string package = Console.ReadLine();

            string hallType = "";

            double hallPrice = 0;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            else
            {
                if (groupSize <= 50)
                {
                    hallPrice = 2500;
                    hallType = "Small Hall";
                    Console.WriteLine($"We can offer you the {hallType}");
                }

                else if (groupSize > 50 && groupSize <= 100)
                {
                    hallPrice = 5000;
                    hallType = "Terrace";
                    Console.WriteLine($"We can offer you the {hallType}");
                }

                else if (groupSize > 100 && groupSize <= 120)
                {
                    hallPrice = 7500;
                    hallType = "Great Hall";
                    Console.WriteLine($"We can offer you the {hallType}");
                }

                double packagePrice = 0;
                double discount = 0;

                switch (package)
                {
                    case "Normal": packagePrice = 500; discount = 5; break;
                    case "Gold": packagePrice = 750; discount = 10; break;
                    case "Platinum": packagePrice = 1000; discount = 15; break;
                }

                double totalPrice = (hallPrice + packagePrice) * (100 - discount) / 100;

                double singlePrice = totalPrice / groupSize;

                Console.WriteLine($"The price per person is {singlePrice:f2}$");
            }

        }
    }
}
