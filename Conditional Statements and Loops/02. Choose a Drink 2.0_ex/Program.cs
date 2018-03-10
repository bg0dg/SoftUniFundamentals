using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink_ex
{
    class Program
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();

            var quantity = int.Parse(Console.ReadLine());

            string drink = "";

            double bill = 0;

            switch (profession)
            {
                case "Athlete": drink = "Water"; bill = quantity * 0.7;  break;
                case "Businessman":
                case "Businesswoman": drink = "Coffee"; bill = quantity * 1; break;
                case "SoftUni Student": drink = "Beer"; bill = quantity * 1.7; break;
                default: drink = "Tea"; bill = quantity * 1.2; break;
            }

            Console.WriteLine($"The {profession} has to pay {bill:f2}.");
        }
    }
}
