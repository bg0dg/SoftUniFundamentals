using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var numToMultiply = int.Parse(Console.ReadLine());

            var startMultiplier = int.Parse(Console.ReadLine());

            var result = 0;


            if (startMultiplier <= 10)
            {
                for (var i = startMultiplier; i <= 10; i++)
                {
                    result = numToMultiply * i;
                    Console.WriteLine($"{numToMultiply} X {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine($"{numToMultiply} X {startMultiplier} = {numToMultiply * startMultiplier}");
            }

        }
    }
}
