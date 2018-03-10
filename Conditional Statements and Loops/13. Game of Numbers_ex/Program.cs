using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = int.Parse(Console.ReadLine());
            var secondLine = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinationCounterEqualToMagic = 0;
            int combinationCounter = 0;
            int firstMagicNumber = 0;
            int secondMagicNumber = 0;

            for (int i = firstLine; i <= secondLine; i++)
            {
                for (int k = firstLine; k <= secondLine; k++)
                {
                    sum = i + k;
                    combinationCounter++;

                    if (sum == magicNumber)
                    {
                        combinationCounterEqualToMagic++;
                        firstMagicNumber = i;
                        secondMagicNumber = k;
                    }

                    if (i == secondLine && k == secondLine && combinationCounterEqualToMagic > 0)
                    {
                        Console.WriteLine($"Number found! {firstMagicNumber} + {secondMagicNumber} = {firstMagicNumber + secondMagicNumber}");
                    }

                    else if (  i == secondLine && k == secondLine && combinationCounterEqualToMagic == 0)
                    {
                        Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
                    }

                }
            }
        }
    }
}
