using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            var maxValue = GetMax(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(maxValue);
        }

        static int GetMax(int firstNumberMathod, int secondNumberMethod, int thirdNumberMethod)
        {
            int maxValueMethod = Math.Max(firstNumberMathod, Math.Max(secondNumberMethod, thirdNumberMethod));
            return maxValueMethod;

        }
    }
}
