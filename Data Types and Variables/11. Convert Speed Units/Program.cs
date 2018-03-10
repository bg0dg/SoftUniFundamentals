using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = int.Parse(Console.ReadLine());
            float hours = int.Parse(Console.ReadLine());
            float minutes = int.Parse(Console.ReadLine());
            float seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 60 * 60 + (minutes * 60) + seconds;
            float timeInHours = hours + (minutes / 60) + (seconds / 60 / 60);
            float metersPerSecond = distanceInMeters / timeInSeconds;
            float kilometersPerHour = distanceInMeters / 1000 / timeInHours;
            float milesPerHour = distanceInMeters / 1609 / timeInHours;

            Console.WriteLine($"{metersPerSecond:0.######}");
            Console.WriteLine($"{kilometersPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");
        }
    }
}
