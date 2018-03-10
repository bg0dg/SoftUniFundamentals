using System;
using System.Linq;

namespace _04._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int scope = int.Parse(Console.ReadLine());
            bool[] primeArray = new bool[scope + 1];

            for (int i = 2; i <= scope; i++)
            {
                primeArray[i] = true;
            }

            for (int prime = 2; prime <= scope; prime++)
            {
                if (primeArray[prime] == true)
                {
                    Console.Write(prime + " ");

                    for (int i = prime * prime; i <= scope; i+= prime)
                    {
                            primeArray[i] = false;
                    }
                }
            }
        }
    }
}
