using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            char[] firstString = input[0].ToArray();
            char[] secondString = input[1].ToArray();

            var longerString = new List<char>();
            var shorterString = new List<char>();

            if (firstString.Length > secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    longerString.Add(firstString[i]);
                }

                for (int i = 0; i < secondString.Length; i++)
                {
                    shorterString.Add(secondString[i]);
                }        
            }

            else if (firstString.Length < secondString.Length)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    longerString.Add(secondString[i]);
                }

                for (int i = 0; i < firstString.Length; i++)
                {
                    shorterString.Add(firstString[i]);
                }
                
            }

            int Totalresult = 0;

            if (firstString.Length == secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    int tempResult = 0;

                    tempResult = firstString[i] * secondString[i];

                    Totalresult += tempResult;
                }
            }
           else
           {
               var diff = longerString.Count - shorterString.Count;
        
               for (int i = 0; i < shorterString.Count; i++)
               {
                   int tempResult = 0;
        
                    tempResult = firstString[i] * secondString[i];
        
                   Totalresult += tempResult;
               }

                for (int i = 1; i <= diff; i++)
                {
                    Totalresult += longerString[shorterString.Count - 1 + i];
                }
           }
        
           Console.WriteLine(Totalresult);
        }
    }
}
