using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var givenNumber = int.Parse(Console.ReadLine());

            while (givenNumber % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                givenNumber = int.Parse(Console.ReadLine());
            }

            if (givenNumber < 0)
            {
                givenNumber = givenNumber * (-1);
            }

            Console.WriteLine($"The number is: {givenNumber}");

        }
    }
}
