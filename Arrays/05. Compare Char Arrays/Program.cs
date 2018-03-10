using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            string flag = "";

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {

                if (firstArray[i] > secondArray[i])
                {
                    flag = "second";
                    break;
                }
         
                else if (firstArray[i] < secondArray[i])
                {
                    flag = "first";
                    break;
                }

                else if (firstArray[i] == secondArray[i])
                {
                    if(firstArray.Length < secondArray.Length)
                    {
                        flag = "first";
                    }
                    else
                    {
                        flag = "second";
                    }
                }
            }

            if (flag == "first")
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }

            if (flag == "second")
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
            }
        }
    }
}
