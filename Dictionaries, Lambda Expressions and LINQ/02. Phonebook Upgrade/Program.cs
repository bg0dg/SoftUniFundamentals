using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            inputList = Console.ReadLine().Split(' ').ToList();



            while (inputList[0] != "END")
            {
                if (inputList[0] == "A")
                {
                    phonebook[inputList[1]] = inputList[2];
                }

                else if (inputList[0] == "S")
                {
                    foreach (var kvp in phonebook)
                    {
                        if (kvp.Key == inputList[1])
                        {
                            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                        }
                    }

                    if (phonebook.ContainsKey(inputList[1]) == false)
                    {
                        Console.WriteLine($"Contact {inputList[1]} does not exist.");
                    }

                }

                else if (inputList[0] == "ListAll")
                {
                    foreach (var kvp in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                inputList = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
