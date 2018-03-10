using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long toCheck = long.Parse(Console.ReadLine());

            CheckNumberIsPrime(toCheck);
        }

        static void CheckNumberIsPrime(long toCheckMethod)
        {
            bool isPrime = true;

            if (toCheckMethod == 0 || toCheckMethod == 1)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(toCheckMethod); i++)
            {
                if (toCheckMethod % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime);
        }
    }
}
