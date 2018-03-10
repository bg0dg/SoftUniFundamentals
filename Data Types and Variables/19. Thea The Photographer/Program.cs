using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPitures = double.Parse(Console.ReadLine());
            double secondsForFiltering = double.Parse(Console.ReadLine());
            double factorOfGoodPics = double.Parse(Console.ReadLine());
            double uploadingTime = double.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(numberOfPitures * factorOfGoodPics / 100);

            var totalTime = numberOfPitures * secondsForFiltering + filteredPictures * uploadingTime;

            TimeSpan timeResult = TimeSpan.FromSeconds(totalTime);

            string formatResult = @"d\:hh\:mm\:ss";

            Console.WriteLine(timeResult.ToString(formatResult));

        }
    }
}
