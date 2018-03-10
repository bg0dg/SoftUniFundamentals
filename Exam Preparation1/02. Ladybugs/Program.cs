using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArraySize = int.Parse(Console.ReadLine());
            //On the first line you will receive an integer - the size of the field

            List<int> bugPlaces = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            //The given indexes may or may not be inside the field range

            int[] ArrayField = new int[ArraySize];

            string[] commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int indexForMoving = int.Parse(commandLine[0]);
            string command = commandLine[1];
            int flyLength = int.Parse(commandLine[2]);

            for (int i = 0; i < bugPlaces.Count; i++)
            {
               ArrayField[bugPlaces[i]] = 1;
            }

            while (command != "end")
            {

                if (flyLength < 0)
                {
                    if (command == "left")
                    {
                        command = "right";
                    }
                    if (command == "right")
                    {
                        command = "left";
                    }
                }

                if (command == "left")
                {
                    try
                    {
                        ArrayField[indexForMoving] = 0;

                        while (indexForMoving - flyLength >= 0)
                        {
                            if (ArrayField[indexForMoving - flyLength] == 0)
                            {
                                ArrayField[indexForMoving - flyLength] = 1;

                                break;
                            }

                            indexForMoving -= flyLength;
                        }

                    }
                    catch
                    {
                        ArrayField[indexForMoving] = 0;
                    }
                }


                if (command == "right")
                {
                    try
                    {
                        ArrayField[indexForMoving] = 0;

                        while (indexForMoving + flyLength <= ArrayField.Length - 1)
                        {
                            if (ArrayField[indexForMoving + flyLength] == 0)
                            {
                                ArrayField[indexForMoving + flyLength] = 1;

                                break;
                            }

                            indexForMoving += flyLength;
                        }

                    }
                    catch
                    {
                        ArrayField[indexForMoving] = 0;
                    }

                }

                //Input
                commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
             
                try
                {
                    command = commandLine[1];
                }
                catch
                {
                    break;
                }

                indexForMoving = int.Parse(commandLine[0]);

                flyLength = int.Parse(commandLine[2]);

            }

            Console.WriteLine(string.Join(" ", ArrayField));

        }
    }
}
