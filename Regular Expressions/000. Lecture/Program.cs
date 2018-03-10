using System;
using System.Text.RegularExpressions;

namespace _000._Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // string pattern = @"A\w+";
            //
            // Regex regex = new Regex(pattern);

            Regex regexText = new Regex(@"[AB]\w+");

            string text = "This is some text - Aahh, Behhh";

            bool hasRegexText = regexText.IsMatch(text);

            Match match = regexText.Match(text);

            var matches = regexText.Matches(text);

            foreach (Match match1 in matches)
            {
                Console.WriteLine($"All match Values:{match1.Value}");
            }

            Console.WriteLine(hasRegexText);

            Console.WriteLine($"Value:{match.Value}");
            Console.WriteLine($"Length:{match.Length}");
            Console.WriteLine($"Index:{match.Index}");
            Console.WriteLine($"Next match Value:{match.NextMatch().Value}");
        }
    }
}
