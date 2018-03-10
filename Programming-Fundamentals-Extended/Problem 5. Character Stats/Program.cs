using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string healthRateString = new string('|', currentHealth);
            string healthRestString = new string('.', maxHealth - currentHealth);

            string energyRateString = new string('|', currentEnergy);
            string energyRestString = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}"); 
            Console.WriteLine($"Health: |{healthRateString}{healthRestString}|");
            Console.WriteLine($"Energy: |{energyRateString}{energyRestString}|");

        }
    }
}
