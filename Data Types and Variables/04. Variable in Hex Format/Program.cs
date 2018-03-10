using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            //int var1 = 0xFE;

            //Console.WriteLine(var1);

            string var11 = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(var11, 16));
        }
    }
}
