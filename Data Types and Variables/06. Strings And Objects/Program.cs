using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object bothWords = firstWord + ' ' + secondWord;
            string bothWordsString = (string) bothWords;

            Console.WriteLine(bothWordsString);
        }
    }
}
