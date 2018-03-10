using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibNnumber = int.Parse(Console.ReadLine());

            FibNumber(fibNnumber);
        }

        static void FibNumber(int n)
        {
            int f0 = 1;
            int f1 = 1;
            int oldF1;

            for (int i = 0; i < n - 1; i++)
            {
                oldF1 = f1;
                f1 += f0;
                f0 = oldF1;
            }

            Console.WriteLine(f1);
        }
    }
}
