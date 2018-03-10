using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Even" && inputLine != "Odd") //върти докато не е въведено "Even" или "Odd"
            {
                string [] command = inputLine.Split(' ').ToArray(); //четем командата и числото и го слагаме в масив

                if(command[0] == "Delete") 
                {
                    int number = int.Parse(command[1]); //объща се подаденото число в int

                    for (int i = 0; i < inputList.Count; i++) //повтаря се изтриването проверявайки всички елементи
                    {
                        inputList.Remove(number); //това изтрива само един елемент от списъка
                    }
                }

                else if(command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    inputList.Insert(index, element);
                }

                inputLine = Console.ReadLine();
            }

            if(inputLine == "Odd")
            {
                foreach(var element in inputList)
                {
                    if(element % 2 != 0)
                    {
                        Console.Write(element + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var element in inputList)
                {
                    if (element % 2 == 0)
                    {
                        Console.Write(element + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
