using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients_ex
{
    class Program
    {
        static void Main(string[] args)
        {

            string ingredient = "";

            int counter = 0;

            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();

                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;
                }
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
