using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial_Frame
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
