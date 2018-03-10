using System;
using System.Text.RegularExpressions;

namespace _02._Extract_Sentences_by_Keyword_second
{
    class Program
    {
        static void Main(string[] args)
        {
            string KeyWord = Console.ReadLine();
            string input = Console.ReadLine();

            Regex searchCriteria = new Regex($@"[^.!?]+{KeyWord}[\s,][^.!?]+");       
            var matches = searchCriteria.Matches(input);
        
            foreach (Match findSentence in matches)
            {
                Console.Write(findSentence.Value.TrimStart());
                Console.WriteLine();
            }
        }
    }
}
