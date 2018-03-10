using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            if(num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            int sum = 0;

            int reminder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = num1.Length-1; i >= 0; i--)
            {
                int num1Int = int.Parse(num1[i].ToString());
                int num2Int = int.Parse(num2[i].ToString());

                sum = num1Int + num2Int + reminder;

                if (sum < 10)
                {
                    result.Append(sum);
                    reminder = 0;
                }

                else
                {                   
                    result.Append((sum) % 10);
                    reminder = 1;

                    if (i == 0)
                    {
                        result.Append(reminder);
                    }
                }

            }

             Console.WriteLine(string.Join("", result.ToString().TrimEnd('0').ToCharArray().Reverse()));
        }
    }
}
