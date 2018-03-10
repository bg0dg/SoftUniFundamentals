using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            ReverseNumberDigitOrder(inputNumber);
        }

        static void ReverseNumberDigitOrder(string ReverseNumberDigitOrderMethod)
        {
            //reverseNum = ""; Втори вариант с конкатенация.

            for (int i = ReverseNumberDigitOrderMethod.Length-1; i >= 0; i--)
            {
                //reverseNum += ReverseNumberDigitOrderMethod [i];

                char printChar = ReverseNumberDigitOrderMethod[i];
                Console.Write(printChar);
            }

            //Console.WriteLine(reverseNum);

            Console.WriteLine();
        }
    }
}
