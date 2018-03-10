using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger baseNum = input[0];
            BigInteger numToConvert = input[1];
            BigInteger rem = 0;

            /*  string convertedNum = "";

               while (numToConvert != 0)
               {
                   rem = numToConvert % baseNum;
                   numToConvert /= baseNum;
                   convertedNum += rem.ToString();
               }

               var revConvertedNum = convertedNum.Reverse();

               Console.WriteLine(String.Join("", revConvertedNum)); */

            StringBuilder convertedNum = new StringBuilder(); //Решение със StringBuilder

            while (numToConvert != 0)
            {
                rem = numToConvert % baseNum;
                numToConvert /= baseNum;
                convertedNum.Append(rem.ToString());
            }
             
            var revConvertedNum = convertedNum.ToString().Reverse();

            Console.WriteLine(String.Join("", revConvertedNum));

        }
    }
}
