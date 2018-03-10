using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes >= 60)
            {
                hour ++;
                if (hour == 24) hour = 0;

                minutes = minutes - 60;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");

        }
    }
}
