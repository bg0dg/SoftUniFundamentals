using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 1;
            int couterMax = 1;
            int numberMax = 0;

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if(numbersArray[i] == numbersArray[i - 1])
                {
                    counter++;
                }
                else
                {
                    if(counter > couterMax)
                    {
                        couterMax = counter;
                        numberMax = numbersArray[i - 1];
                    }

                    counter = 1;
                }

                if( i == numbersArray.Length - 1)
                {
                    if (counter > couterMax)
                    {
                        couterMax = counter;
                        numberMax = numbersArray[i - 1];
                    }
                    counter = 1;
                }
            }

         //   for (int i = 0; i < couterMax; i++)
         //   {
         //       Console.Write(numberMax + " ");
         //   }

            for (int i = 0; i < couterMax; i++)
            {
                Console.Write(numberMax + " ");
            }

            Console.WriteLine();
        }
    }
}
