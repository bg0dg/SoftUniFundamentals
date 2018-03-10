using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputResource = Console.ReadLine();

            int quantity = 0;

            Dictionary<string, long> mine = new Dictionary<string, long>();

            while(inputResource != "stop")
            {
                quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(inputResource))
                {     
                    mine.Add(inputResource, quantity);
                }
                else
                {
                    mine[inputResource] += quantity;
                }

                inputResource = Console.ReadLine();
            }

            foreach (var kvp in mine)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
