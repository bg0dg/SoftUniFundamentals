﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _02._Convert_from_base_N_to_base_10_second_solution
{
    public class FromBase
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split();
            int baseN = int.Parse(line[0]);
            char[] number = line[1].ToCharArray();
            BigInteger result = new BigInteger(0);
            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += forSum;
            }
            Console.WriteLine(result.ToString());
        }
    }
}