using System;
using System.Collections.Generic;

namespace _07._Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            FindPrimesInRange(startNum, endNum);

            var result = String.Join(", ", FindPrimesInRange(startNum, endNum)); //изпечатва последователно елементите на масива отделени със запетая

            System.Console.WriteLine(result);

        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeList = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {

                    if (i % j == 0)
                    {
                        isPrime = false;
                    }

                }

                if (isPrime && i != 0 && i !=1)
                {
                    primeList.Add(i);                    
                }               
            }

            return primeList;

        }
    }
}
