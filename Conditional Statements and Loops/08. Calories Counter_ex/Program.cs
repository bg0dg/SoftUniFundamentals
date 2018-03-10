using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            int calories = 0;

            for (var i = 1; i <= numberOfLines; i++)
            {

                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese") calories += 500;
                else if (ingredient == "tomato sauce") calories += 150;
                else if (ingredient == "salami") calories += 600;
                else if (ingredient == "pepper") calories += 50;
                else Console.Write("");
            }

            Console.WriteLine($"Total calories: {calories}");



        }
    }
}
