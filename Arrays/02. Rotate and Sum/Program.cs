using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int kTimesRotationIndex = int.Parse(Console.ReadLine());

            int[] result = new int[initialArray.Length];

            for (int k = 0; k < kTimesRotationIndex; k++)
            {
                int lastArrayElement = initialArray[initialArray.Length - 1];

                for (int index = initialArray.Length - 1; index > 0; index --)
                {
                    initialArray[index] = initialArray[index - 1];
                    result[index] += initialArray[index];
                }

                initialArray[0] = lastArrayElement;

                result[0] += initialArray[0];

            }

                Console.WriteLine(String.Join(" ", result));
        }
    }
}
