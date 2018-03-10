using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (var i = 1; i <= number; i++)
            {
                for (var k = 1; k <= i; k++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
