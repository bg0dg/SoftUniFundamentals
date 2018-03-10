using System;
using System.Linq;

namespace _08._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int resultNumber = 0;
            int totalOccurances = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int currentNumber = numbersArray[i];
                int currentOccurances = 0;

                for (int k = i; k < numbersArray.Length; k++)
                {
                    if(currentNumber == numbersArray[k])
                    {
                        currentOccurances++;
                        if(currentOccurances > totalOccurances)
                        {
                            totalOccurances = currentOccurances;
                            resultNumber = currentNumber;
                        }
                    }
                }
            }

            Console.WriteLine(resultNumber);
        }
    }
}
