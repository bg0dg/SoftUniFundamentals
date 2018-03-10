using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _05._Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyLine = Console.ReadLine();
            string targetText = Console.ReadLine();

            string keyPatern = @"(^[a-zA-Z]+)(<|\||\\).+(<|\||\\)([a-zA-Z]+)";

            var validInput = Regex.Match(keyLine, keyPatern);

            string firstKey = validInput.Groups[1].ToString();
            string secondKey = validInput.Groups[4].ToString();

            string searchPatern = $@"({firstKey})(.*?)({secondKey})";

            MatchCollection foundWordsRegex = Regex.Matches(targetText, searchPatern);

            //Този вариант работи, но не се компилира в Judge
            // string foundWords = "";
            //
            // foreach (var item in foundWordsRegex.ToList())
            // {
            //     foundWords += item.Groups[2];
            // }
            //По-долу вариант със StringBuilder

            StringBuilder foundWords = new StringBuilder();

            foreach (Match word in foundWordsRegex)
            {
                foundWords.Append(word.Groups[2].Value);
            }

            if (foundWords.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(foundWords);
            }

        }
    }
}
