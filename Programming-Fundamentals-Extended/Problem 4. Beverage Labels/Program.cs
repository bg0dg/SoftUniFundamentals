using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());

            var energyContentInVolume = volume * energyContent / 100;

            var sugarContentInVolume = volume * sugarContent / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContentInVolume}kcal, {sugarContentInVolume}g sugars");
        }
    }
}
