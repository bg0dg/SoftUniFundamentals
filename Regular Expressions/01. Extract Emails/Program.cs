using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(^| )[A-Za-z0-9][A-Za-z0-9.\-_]*@[A-Za-z\-]+(\.[a-z]+)+");

            var matches = regex.Matches(input);

            foreach (Match email in matches)
            {
                Console.Write(email.Value);
                Console.WriteLine();
            }
        }
    }
}
