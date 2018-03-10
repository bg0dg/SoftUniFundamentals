using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray(); //inputArray.Lenght = 4 * k

            int[] foldingBaseArray = new int[inputArray.Length / 2];
            int[] foldingTopArrayLeft = new int[inputArray.Length / 4];
            int[] foldingTopArrayRight = new int[inputArray.Length / 4];

            int k = inputArray.Length / 4;

            for (int i = 0; i < foldingBaseArray.Length; i++)
            {
                foldingBaseArray[i] = inputArray[k + i]; 
            }

            for (int i = 0; i < foldingTopArrayLeft.Length; i++)
            {
                foldingTopArrayLeft[i] = inputArray[i];
            }

            Array.Reverse(foldingTopArrayLeft);


            for (int i = 0; i < foldingTopArrayRight.Length; i++)
            {
                foldingTopArrayRight[(foldingTopArrayRight.Length - 1) - i] = inputArray[(inputArray.Length - 1) - i];
            }

            Array.Reverse(foldingTopArrayRight);

            int[] sum = new int[inputArray.Length / 2];

            for (int i = 0; i < foldingTopArrayLeft.Length; i++)
            {

                sum[i] = foldingBaseArray[i] + foldingTopArrayLeft[i];
            }

            for (int i = 0; i < foldingTopArrayRight.Length; i++)
            {
                sum[(sum.Length - 1) - i] = foldingBaseArray[(foldingBaseArray.Length - 1) - i] + foldingTopArrayRight[(foldingTopArrayRight.Length - 1) - i];
            }

            Console.WriteLine(String.Join(" ", sum));

        }
    }
}
