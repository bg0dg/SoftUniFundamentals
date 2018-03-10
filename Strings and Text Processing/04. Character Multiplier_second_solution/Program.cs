using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _04._Character_Multiplier_second_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string word1 = input[0];
            string word2 = input[1];

            int result = 0;

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                result += word1[i] * word2[i];
            }

            for (int i = Math.Min(word1.Length, word2.Length); i < Math.Max(word1.Length, word2.Length); i++)
            {
                try
                {
                    result += word1[i];
                }
                catch
                {
                    result += word2[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
