using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfOdds = int.Parse(Console.ReadLine());

            int sum = 0;

            int counter = 0;

            for (var n = 1; n <= 200; n+=2)
            {
                Console.WriteLine(n);
                counter ++;
                sum = sum + n;

                if (counter == numberOfOdds)
                {
                    Console.WriteLine($"Sum: {sum}");
                    n = 200;
                }
            }

        }
    }
}
