﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write("\\u" + "{0:x4}", (int) symbol);
            }
            Console.WriteLine();
        }
    }
}
