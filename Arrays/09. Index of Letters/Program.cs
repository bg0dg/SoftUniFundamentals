using System;
using System.Linq;

namespace _09._Index_of_Letters
{
    class Program
    {
        private static int length;

        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] alphabet = new char[26];

            int indexCounter = 0;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                alphabet[indexCounter] = letter;
                indexCounter++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];

                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (currentLetter == alphabet[k])
                    {
                        Console.WriteLine($"{currentLetter} -> {k}");
                    }
                }
            }

            char test = char.Parse(Console.ReadLine());
            Console.WriteLine(test);
        }
    }
}
