﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var numToMultiply = int.Parse(Console.ReadLine());
            var result = 0;

            for (var i = 1; i<=10; i++)
            {
                result = numToMultiply * i;
                Console.WriteLine($"{numToMultiply} X {i} = {result}");
            }


        }
    }
}
