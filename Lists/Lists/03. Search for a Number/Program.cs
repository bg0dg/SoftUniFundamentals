using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> rulesList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int numTakenElement = rulesList[0];
            int numDeletedElement = rulesList[1];
            int searchedNum = rulesList[2];

            List<int> tookList = new List<int>();

            for (int i = 0; i < numTakenElement; i++)
            {
                tookList.Add(inputList[i]);
            }

            for (int i = 0; i < numDeletedElement; i++)
            {
                tookList.RemoveAt(0);
            }

            bool isFound = false;

            foreach (var element in tookList)
            {
                if(element == searchedNum)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }


        }
    }
}
