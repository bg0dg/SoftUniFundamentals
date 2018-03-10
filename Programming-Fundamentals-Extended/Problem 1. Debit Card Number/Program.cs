using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCard = int.Parse(Console.ReadLine());
            int secondCard = int.Parse(Console.ReadLine());
            int thirthCard = int.Parse(Console.ReadLine());
            int fourthCard = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstCard:d4} {secondCard:d4} {thirthCard:d4} {fourthCard:d4}");

        }
    }
}
