using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine(); ;
            double result = 0;


            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = TriangleFaceCalc(side, height);           
            }

            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                result = SquareFaceCalc(side);
            }

            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                result = RectangleFaceCalc(width, height);
            }

            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                result = CircleFaceCalc(radius);
            }

            Console.WriteLine($"{result:f2}");
        }

        static double TriangleFaceCalc(double sideMethod, double heightMethod)
        {
            double resultMethod = sideMethod * heightMethod / 2;
            return resultMethod;
        }

        static double SquareFaceCalc(double sideMethod)
        {
            double resultMethod = sideMethod * sideMethod;
            return resultMethod;
        }

        static double RectangleFaceCalc(double widthMethod, double heightMethod)
        {
            double resultMethod = widthMethod * heightMethod;
            return resultMethod;
        }

        static double CircleFaceCalc(double radiusMethod)
        {
            double resultMethod = Math.PI * Math.Pow(radiusMethod, 2);
            return resultMethod;
        }
    }
}
