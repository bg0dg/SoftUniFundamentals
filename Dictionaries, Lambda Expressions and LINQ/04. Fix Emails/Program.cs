using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailBook = new Dictionary<string, string>();
            string name = "";
            string email = "";
            string command = Console.ReadLine();

            while(command != "stop")
            {
                name = command;
                email = Console.ReadLine();

                if (!mailBook.ContainsKey(name))
                {
                    mailBook.Add(name, email);
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in mailBook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
