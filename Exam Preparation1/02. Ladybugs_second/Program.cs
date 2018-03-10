using System;
using System.Linq;

namespace _02._Ladybugs_second
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); 
            var field = new int[fieldSize];
            
            var ladyBugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Where(i => i >= 0 && i < fieldSize).ToList();

            foreach (var index in ladyBugIndexes)
            {
                field[index] = 1; //ladybug here
            }

            //Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse).Where(i => i >= 0 && i < fieldSize).ToList()
            //    .ForEach(index => field[index] = 1);
            // Това прави същото като горните редове след 13-ти.

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                var commandParts = line.Split(' ');

                var currentLadyBugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLength = int.Parse(commandParts[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                if (currentLadyBugIndex < 0 || currentLadyBugIndex >= fieldSize) //outside of field
                {
                    continue;
                }

                if (field[currentLadyBugIndex] == 0) //no ladyBug here
                {
                    continue;
                }

                field[currentLadyBugIndex] = 0; //fly away

                var nextIndexToLand = currentLadyBugIndex;

                while (true)
                {
                    nextIndexToLand += flyLength;

                    if (nextIndexToLand < 0 || nextIndexToLand >= fieldSize)
                    {
                        break;
                    }

                    if (field[nextIndexToLand] == 1) //there is a ladyBug already
                    {
                        continue;
                    }

                    field[nextIndexToLand] = 1;

                    break; //just landed
                }
            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}
