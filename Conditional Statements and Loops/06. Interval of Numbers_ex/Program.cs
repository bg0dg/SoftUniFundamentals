using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var biggerNumber = Math.Max(firstNumber, secondNumber);
            var smallerNumber = Math.Min(firstNumber, secondNumber);

            for (var i = smallerNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
