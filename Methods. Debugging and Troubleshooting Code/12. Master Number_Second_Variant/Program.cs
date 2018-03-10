using System;

namespace _12._Master_Number_Second_Variant
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= inputNumber; currentNumber++)
            {
                //TO DO if all 3 are true

                if (IsSymetric(currentNumber) == true && IsSumOfDigitsDivToSeven(currentNumber) == true && HasEvenDigit(currentNumber) == true)
                {
                    Console.WriteLine(currentNumber);
                }

            }
        }

        static bool IsSymetric(int number)
        {
            string currentNumberToCheck = number.ToString();

            int counter = 0;

            for (int i = currentNumberToCheck.Length - 1; i >= 0; i--)
            {
                if (currentNumberToCheck[i] != currentNumberToCheck[counter]) //Сравнява стринговете отзад напред и обратно
                {
                    return false; //exit from the Method
                }
                counter++;
            }
            return true;
        }

        static bool IsSumOfDigitsDivToSeven(int inputNumber)
        {
            int sum = 0;

            while (inputNumber >= 1)
            {
                sum += inputNumber % 10;
                inputNumber /= 10;
            }

            bool isDevToSeven = false;

            if (sum % 7 == 0)
            {
                isDevToSeven = true;
            }

            return isDevToSeven;
        }

        static bool HasEvenDigit(int inputNumber)
        {
            bool hasEvenDigit = false;

            while (inputNumber >= 1)
            {
                if (inputNumber % 2 == 0)
                {
                    hasEvenDigit = true;
                }

                inputNumber /= 10;
            }

            return hasEvenDigit;
        }
    }
}
