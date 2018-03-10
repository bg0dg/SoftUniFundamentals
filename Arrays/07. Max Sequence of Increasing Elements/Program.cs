using System;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startIndex = 0;
            int currentLength = 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > numbersArray[i - 1])
                {
                    currentLength++;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = startIndex;
                    }
                }
                else
                {
                    currentLength = 1;
                    startIndex = i;
                }
            }

            for (int i = maxStart; i < maxStart + maxLength; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
