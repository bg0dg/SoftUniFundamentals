using System;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string KeyWord = Console.ReadLine();
            string[] sentenceArray = Console.ReadLine().Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentence in sentenceArray)
            {
                var words = Regex.Split(sentence, @"[^A-Aa-z0-9]+");

                foreach (var word in words)
                {
                    if (word == KeyWord)
                    {
                        Console.WriteLine(sentence);
                        break;
                    }
                }
            }
        }
    }
}
