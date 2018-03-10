using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            string message = "";
            bool canFit = false;

            try
            {
                sbyte num = sbyte.Parse(inputNumber);
                message += "* sbyte\r\n";
                canFit = true;
            }
            catch{}

            try
            {
                byte num = byte.Parse(inputNumber);
                message += "* byte\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                short num = short.Parse(inputNumber);
                message += "* short\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                ushort num = ushort.Parse(inputNumber);
                message += "* ushort\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                int num = int.Parse(inputNumber);
                message += "* int\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                uint num = uint.Parse(inputNumber);
                message += "* uint\r\n";
                canFit = true;
            }
            catch { }

            try
            {
                long num = long.Parse(inputNumber);
                message += "* long\r\n";
                canFit = true;
            }
            catch { }

            if (canFit)
            {
                Console.WriteLine($"{inputNumber} can fit in:");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{inputNumber} can't fit in any type");
            }

        }
    }
}
