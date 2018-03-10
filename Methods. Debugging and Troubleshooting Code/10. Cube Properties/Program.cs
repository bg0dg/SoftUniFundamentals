using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeFeatuteToCalculate = Console.ReadLine();

            CubeCalculation(cubeFeatuteToCalculate, cubeSide);
        }

        static void CubeCalculation(string whatToCalculate, double cubeSide)
        {
            switch (whatToCalculate)
            {
                case "face":
                    double cubeFaceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
                    Console.WriteLine($"{cubeFaceDiagonal:f2}");
                break;

                case "space":
                    double cubeSpaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
                    Console.WriteLine($"{cubeSpaceDiagonal:f2}");
                break;

                case "volume":
                    double cubeVolume = Math.Pow(cubeSide, 3);
                    Console.WriteLine($"{cubeVolume:f2}");
                break;

                case "area":
                    double cubeArea = 6 * Math.Pow(cubeSide, 2);
                    Console.WriteLine($"{cubeArea:f2}");
                break;
            }

        }

    }
}
