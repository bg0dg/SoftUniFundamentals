using System;
using System.Linq;

namespace Closest_Two_Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();

            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }

            return closestTwoPoints;
        }

        static void PrintDistance(Point[] closestPoints)
        {
            double distance = CalcDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine($"{distance:f3}");
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static Point[] ReadPoints() //връща масив от точки с координати
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray(); //Прочитам входа и го правя на масив

            //   Point point = new Point()
            //   {
            //       X = pointInfo[0],
            //       Y = pointInfo[1]
            //   };

            Point point = new Point(); // Създавам нов обект point от клас Point с свойства X и Y
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        } //връща координати на една точка

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
