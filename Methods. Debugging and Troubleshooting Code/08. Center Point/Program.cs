using System;

namespace _08._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosestPoint(x1, x2, y1, y2);

        }

        static void ClosestPoint(double x1Method, double y1Method, double x2Method, double y2Method)
        {
            double distanceFirstPoint = Math.Sqrt(Math.Pow(x1Method, 2) + Math.Pow(y1Method, 2));
            double distanceSecondPoint = Math.Sqrt(Math.Pow(x2Method, 2) + Math.Pow(y2Method, 2));

            if (distanceFirstPoint <= distanceSecondPoint)
            {
                Console.WriteLine($"({x1Method}, {y1Method})");
            }

            else
            {
                Console.WriteLine($"({x2Method}, {y2Method})");
            }
        }
    }
}
