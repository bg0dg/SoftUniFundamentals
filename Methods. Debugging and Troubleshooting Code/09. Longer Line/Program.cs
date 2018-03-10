using System;

namespace _09._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1firstLine = double.Parse(Console.ReadLine());
            double x2firstLine = double.Parse(Console.ReadLine());
            double y1firstLine = double.Parse(Console.ReadLine());
            double y2firstLine = double.Parse(Console.ReadLine());

            double x1secondLine = double.Parse(Console.ReadLine());
            double x2secondLine = double.Parse(Console.ReadLine());
            double y1secondLine = double.Parse(Console.ReadLine());
            double y2secondLine = double.Parse(Console.ReadLine());           

            LongerLine(x1firstLine, x2firstLine, y1firstLine, y2firstLine, x1secondLine, x2secondLine, y1secondLine, y2secondLine);
        }

        static void LongerLine(double x1L1Method, double y1L1Method, double x2L1Method, double y2L1Method,
                                 double x1L2Method, double y1L2Method, double x2L2Method, double y2L2Method)
        {
            double line1 = Math.Sqrt(Math.Pow((x1L1Method - x2L1Method), 2) + Math.Pow((y1L1Method - y2L1Method), 2));
            double line2 = Math.Sqrt(Math.Pow((x1L2Method - x2L2Method), 2) + Math.Pow((y1L2Method - y2L2Method), 2));

            if (line1 >= line2)
            {
                ClosestPoint(x1L1Method, y1L1Method, x2L1Method, y2L1Method);
                FartherPoint(x1L1Method, y1L1Method, x2L1Method, y2L1Method);
            }
            else
            {
                ClosestPoint(x1L2Method, y1L2Method, x2L2Method, y2L2Method);
                FartherPoint(x1L2Method, y1L2Method, x2L2Method, y2L2Method);
            }

            Console.WriteLine();
        }

        static void ClosestPoint(double x1Method, double y1Method, double x2Method, double y2Method)
        {
            double distanceFirstPoint = Math.Sqrt(Math.Pow(x1Method, 2) + Math.Pow(y1Method, 2));
            double distanceSecondPoint = Math.Sqrt(Math.Pow(x2Method, 2) + Math.Pow(y2Method, 2));

            if (distanceFirstPoint <= distanceSecondPoint)
            {
                Console.Write($"({x1Method}, {y1Method})");
            }

            else
            {
                Console.Write($"({x2Method}, {y2Method})");
            }
        }

        static void FartherPoint(double x1Method, double y1Method, double x2Method, double y2Method)
        {
            double distanceFirstPoint = Math.Sqrt(Math.Pow(x1Method, 2) + Math.Pow(y1Method, 2));
            double distanceSecondPoint = Math.Sqrt(Math.Pow(x2Method, 2) + Math.Pow(y2Method, 2));

            if (distanceFirstPoint <= distanceSecondPoint)
            {
                Console.Write($"({x2Method}, {y2Method})");
            }

            else
            {               
                Console.Write($"({x1Method}, {y1Method})");
            }
        }        
    }
}
