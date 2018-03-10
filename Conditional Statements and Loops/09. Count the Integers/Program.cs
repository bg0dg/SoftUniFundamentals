using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            try
            {
                while (true)
                {
                var number = int.Parse(Console.ReadLine());
                counter++;
                }
            }

            catch
            {
                Console.WriteLine(counter);
            }

        }
    }
}
