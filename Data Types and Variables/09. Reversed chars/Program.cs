using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstNum = char.Parse(Console.ReadLine());
            char secondNum = char.Parse(Console.ReadLine());
            char thirdNum = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdNum}{secondNum}{firstNum}");

        }
    }
}
