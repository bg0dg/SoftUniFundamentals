using System;
using System.Linq;


namespace _03._Fold_and_Sum_Better_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = inputArray.Length / 4;

            int[] leftArray = inputArray.Take(k).ToArray();
            int[] middArray = inputArray.Skip(k).Take(2 * k).ToArray();
            int[] rightArray = inputArray.Skip(3 * k).Take(k).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            int[] result = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                result[i] = leftArray[i] + middArray[i];

                result[k + i] = rightArray[i] + middArray[k + i];
            }

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
