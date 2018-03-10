using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int checkNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                for (int k = i; k < numbersArray.Length; k++)
                {
                    if(Math.Max(numbersArray[i], numbersArray[k]) - Math.Min(numbersArray[i], numbersArray[k]) == checkNumber)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
