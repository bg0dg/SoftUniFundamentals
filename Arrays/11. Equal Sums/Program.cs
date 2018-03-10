using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool flag = false;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int[] leftArray = numbersArray.Take(i).ToArray();
                int[] rightArray = numbersArray.Skip(i + 1).ToArray();

                if(leftArray.Sum() == rightArray.Sum())
                {
                    Console.WriteLine(i);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}
