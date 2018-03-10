using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFatorial(number));
        }

        static BigInteger CalculateFatorial(BigInteger number)
        {
            BigInteger factorial = 1;

            for (BigInteger i = number; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
