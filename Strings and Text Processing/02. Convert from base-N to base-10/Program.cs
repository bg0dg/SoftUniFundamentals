using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _02._Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int baseNum = int.Parse(input[0]);
            string numToConvertInTen = input[1];

            BigInteger convertedNum = 0;
            int counterIndex = 0;

            for (int i = numToConvertInTen.Length - 1; i >= 0; i--)
            {
                int index = numToConvertInTen.Length - 1 - i;

                int currentNum = int.Parse(numToConvertInTen.Substring(counterIndex, 1));

                int pow = numToConvertInTen.Length - 1 - counterIndex;

                BigInteger basePow = BigInteger.Pow(baseNum, pow);

                BigInteger result = currentNum * basePow;

                convertedNum += result;

                counterIndex++;
            }

            Console.WriteLine(convertedNum);
        }
    }
}
