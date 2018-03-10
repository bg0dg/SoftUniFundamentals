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
            var thirdLine = int.Parse(Console.ReadLine());
            int multiplication = 0;
            int sum = 0;
            int combinationCounter = 0;

            for (int i = firstLine; i >= 1; i--)
            {
                for (int k = 1; k <= secondLine; k++)
                {
                    multiplication = (i * k) * 3;
                    sum += multiplication;
                    combinationCounter++;

                    if (sum >= thirdLine)
                    {
                        Console.WriteLine($"{combinationCounter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {thirdLine}");
                        return;
                    }

                    else if (sum < thirdLine && i == 1 && k == secondLine)
                    {
                        Console.WriteLine($"{combinationCounter} combinations");
                        Console.WriteLine($"Sum: {sum}");
                    }

                }
            }
        }
    }
}
