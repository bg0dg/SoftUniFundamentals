using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._1_count_number_of_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 1

            Console.WriteLine("Input number list:");

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //чете от конзолата и попълва числата в списък
            var counts = new int[nums.Max() + 1]; //създава масив с макс. дължина на списъка + 1

            foreach (var num in nums) //създава променлива "num", която държи стойността за всеки елемент от списъка "nums", и в цикъл записва стойността в масива "counts" .
            {
                counts[num]++;
            }
                
            for (int i = 0; i < counts.Length; i++) //изписване на съдържанието на масива последователно от 1 -> карая на масива, като прескача числата с повторение 0 пъти;
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }

            //Вариант 2

            Console.WriteLine("Input number list:");

            List<int> nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //чете списъка

            nums1.Sort(); // сортира го

            var pos = 0;

            while (pos < nums1.Count) // върти докато позицията не стигне до края на списъка
            {
                int num = nums1[pos], count = 1; //създава 2 променливи: num - съдържа числото на първа позиция; count - брои повторенията;

                while (pos + count < nums1.Count && nums1[pos + count] == num) // докато се стигне края на списъка и числото което се чете е едно и също;
                {
                    count++; //увеличава брояча.
                }

                pos = pos + count; //измества се нулевата позиция със повторените позиции.

                Console.WriteLine($"{num} -> {count}");
            }


        }
    }
}
