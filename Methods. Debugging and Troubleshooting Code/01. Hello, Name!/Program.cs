﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            PrintName(inputName);
        }

        static void PrintName(string methodhName)
        {
            Console.WriteLine($"Hello, {methodhName}!");
        }
    }
}
