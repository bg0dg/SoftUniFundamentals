using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] specNumAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int specNum = specNumAndPower[0];
            int power = specNumAndPower[1];

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == specNum)
                {
                    if(power <= i)
                    {
                        for (int j = i; j >=  i - power; j--)
                        {
                            inputList[j] = 0;
                        }
                    }

                    if (power > i)
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            inputList[j] = 0;
                        }
                    }

                    if (power + i > inputList.Count)
                    {
                        for (int j = i; j < inputList.Count; j++)
                        {
                            inputList[j] = 0;
                        }
                    }

                    if (power + i < inputList.Count)
                    {
                        for (int j = i; j <= i + power; j++)
                        {
                            inputList[j] = 0;
                        }
                    }
                }

            }

                Console.WriteLine(String.Join(" ", inputList.Sum()));

        }
    }
}
