using System;
using System.Collections.Generic;
using System.Linq;


namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //List<int> numbers = Console.ReadLine()
            //.Split(new char[] { ' ' }, StringSplitOptions
            //.RemoveEmptyEntries).Select(int.Parse).ToList();

            int curentStart = 0;
            int currentLength = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] == numbers[i - 1])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = curentStart;
                    }
                }

                else
                {
                    currentLength = 1;
                    curentStart = i;
                }

            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

        }
    }
}
