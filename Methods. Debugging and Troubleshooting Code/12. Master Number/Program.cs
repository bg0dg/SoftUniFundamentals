using System;

namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int LastRangeNum = int.Parse(Console.ReadLine());

            for (int inputNumber = 1; inputNumber <= LastRangeNum; inputNumber++)
            {
                string convertedToString = inputNumber.ToString();

                ReverseNumberDigitOrder(convertedToString);

                IsPalindrom(convertedToString, ReverseNumberDigitOrder(convertedToString)); //true or false
                if (IsPalindrom(convertedToString, ReverseNumberDigitOrder(convertedToString)) == false) continue;               

                IsSumOfDigitsDivToSeven(inputNumber); //true or false
                if (IsSumOfDigitsDivToSeven(inputNumber) == false) continue;

                HasEvenDigit(inputNumber); //true or false
                if (HasEvenDigit(inputNumber) == false) continue;

                if (IsPalindrom(convertedToString, ReverseNumberDigitOrder(convertedToString)) == true &&
                    IsSumOfDigitsDivToSeven(inputNumber) == true &&
                    HasEvenDigit(inputNumber) == true)
                {
                    Console.WriteLine(inputNumber);
                }
            }
        }

        static string ReverseNumberDigitOrder(string ReverseNumberDigitOrderMethod)
        {
            string reverseNum = ""; 

            for (int i = ReverseNumberDigitOrderMethod.Length - 1; i >= 0; i--)
            {
                reverseNum += ReverseNumberDigitOrderMethod [i];
            }

            return reverseNum;
        }

        static bool IsPalindrom(string inputNumber, string reverseNum)
        {
            bool isPalindrom = false;

            if (inputNumber == reverseNum)
            {
                isPalindrom = true;
            }

            return isPalindrom;
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
