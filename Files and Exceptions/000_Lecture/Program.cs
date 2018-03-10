using System;
using System.Collections.Generic;
using System.IO; //Input Output
using System.Text;

namespace _000_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string textAllText = File.ReadAllText("demo.txt");

            string[] textAllLines = File.ReadAllLines("demo.txt");

            Console.WriteLine(textAllText);
            Console.WriteLine();
            Console.WriteLine(textAllLines[0]);

            File.WriteAllText("WriteAllTextFile.txt", "I am writing in a file.");

            string readCreatedFile = File.ReadAllText("WriteAllTextFile.txt");

            Console.WriteLine(readCreatedFile);

            Console.WriteLine("----------------------");

            var dict = new Dictionary<string, string>
            {
                ["Dimitar"] = "Georgiev",
                ["Maria"] = "Bogoeva",
                ["Alina"] = "Georgieva",
                ["Blaga"] = "Georgieva",
                ["Ivan"] = "Georgiev"
            };

            var result = new StringBuilder();

            foreach (var name in dict)
            {
                result.AppendLine($"{name.Key} - {name.Value}");
            }

            File.WriteAllText("names.txt", result.ToString());

            string readNames = File.ReadAllText("names.txt");

            Console.WriteLine(readNames);

            Console.WriteLine("Write an Array of strings");

            var lines = new string[] { "I", "you", "he", "she", "it" };

            File.WriteAllLines("english_pron.txt", lines);

            //File.AppendAllText("english_pron.txt", "we");
            File.AppendAllText("english_pron.txt", $"they{Environment.NewLine}"); //при повторение добавя нов ред

            Console.WriteLine("----------------------");

            var fileInfo = new FileInfo("english_pron.txt");

            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.DirectoryName);

            Console.WriteLine("read odd lines");

            string[] allLines = File.ReadAllLines("names.txt");

            var resultOddLines = new StringBuilder();

            for (int i = 0; i < allLines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    resultOddLines.AppendLine(allLines[i]);
                }
            }

            File.WriteAllText("odd-lines.txt", resultOddLines.ToString());

            string readAllOddLines = File.ReadAllText("odd-lines.txt");

            Console.WriteLine(readAllOddLines);

            Console.WriteLine("Reading a dictionary from a file");

            string[] allLinesToDict = File.ReadAllLines("names.txt");

            var dictResult = new Dictionary<string, string>();

            foreach (var line in allLinesToDict)
            {
                var lineParts = line.Split('-');

                var firstName = lineParts[0].Trim();
                var lastName = lineParts[1].Trim();

                dictResult[firstName] = lastName;
            }

        }
    }
}
