using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age >= 0 && age <= 18)

            {
                switch (typeOfDay)
                {                
                    case "weekday": price = 12; break; 
                    case "weekend": price = 15; break; 
                    case "holiday": price = 5; break;
                }


            }

            else if (age > 18 && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "weekday": price = 18; break;
                    case "weekend": price = 20; break;
                    case "holiday": price = 12; break;
                }
            }

            else if (age > 64 && age <= 122)
            {
                switch (typeOfDay)
                {
                    case "weekday": price = 12; break;
                    case "weekend": price = 15; break;
                    case "holiday": price = 10; break;
                }
            }

            if (price > 0)
            {
                Console.WriteLine($"{price}$");
            }
            else Console.WriteLine("Error!");
        }
    }
}
