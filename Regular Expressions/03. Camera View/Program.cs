using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _03._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();

            int toSkip = inputNumber[0];
            int toTake = inputNumber[1];

            string searchCriteria = @"\|<(.*?)(?=\||$)";

            // \| - ескейпваме логическото "или"
            // (.*) - 0 или повече пъти
            // $ - край на стринга
            // | логическо "или"
            // (?=\||$) - до | или край на стринга
            // () - затваря група
            // ? - мързеливо търсене; Спира до |
            // ?= - гледай назад; За да намери всичко след |
            // ?: - Прави група, която не се хваща

            MatchCollection cameras = Regex.Matches(text, searchCriteria);

            List<string> result = new List<string>();

            foreach (Match camera in cameras)
            {
                var view = camera.Groups[1].ToString().Skip(inputNumber[0]).Take(inputNumber[1]).ToArray(); 

                var element = String.Concat(view);

                result.Add(element);

            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
