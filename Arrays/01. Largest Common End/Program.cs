using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] secondArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            int lengthShorterArray = Math.Min(firstArray.Length, secondArray.Length);

           int counterFront = 0;  

            for (int i = 0; i < lengthShorterArray; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counterFront++;
                } 
            }

            int counterBack = 0;

            int lenghtArrayCounter = 1;

            for (int i = lengthShorterArray - 1; i >= 0; i--)
            {
                if (firstArray[firstArray.Length-lenghtArrayCounter] == secondArray[secondArray.Length - lenghtArrayCounter])
                {
                    counterBack++;
                }

                lenghtArrayCounter++;
            }

            //Друг начин за обръщане на масив: Array.Reverse(firstArray); => Така се обръща самия масив.

            // Така се създава нов обърнат масив, който се присвоява на даден масив или може да се направи нов такъв =>
            // => secondArray = secondArray.Reverse().ToArray();

            Console.WriteLine(Math.Max(counterFront, counterBack));

        }
    }
}
