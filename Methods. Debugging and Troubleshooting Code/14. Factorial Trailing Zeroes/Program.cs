using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFatorialZeros(number));
        }

        static int CalculateFatorialZeros(BigInteger number)
        {
            BigInteger factorial = 1;

            for (BigInteger i = number; i >= 1; i--)
            {
                factorial *= i;
            }

            int zeroCounter = 0;

            while (factorial % 10 == 0)
            {
                zeroCounter++;
                factorial /= 10;
            }

            return zeroCounter;
        }
    }
}



