using System;
using System.Linq;
using System.Collections.Generic;


namespace Lecture_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> marks = new Dictionary<string, double>();
            // var marks = new Dictionary<string, double>(); - съкратен запис;

            marks["Ivan"] = 6.00;
            marks["Gosho"] = 5.00;
            marks["Pesho"] = 3.00;

            double ivanMark = marks["Ivan"];
            double goshoMark = marks["Gosho"];

            Console.WriteLine("ivanMark");
            Console.WriteLine(ivanMark);
            Console.WriteLine("goshoMark");
            Console.WriteLine(goshoMark);

            //a - 100
            //t - 2568
            //z - 3

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            letterCount['a'] = 100;
            letterCount['t'] = 2568;
            letterCount['t'] = 3000;
            letterCount['z'] = 3;

            Console.WriteLine("letterCount - t");
            Console.WriteLine(letterCount['t']);

            //   letterCount.Remove('t');

            //   if (letterCount['t'])
            //   {
            //       Console.WriteLine(letterCount['t']);
            //   }

            foreach (var pair in letterCount)
            {
                //Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);
                Console.WriteLine($"{pair.Key} --> {pair.Value}");
            }

            Console.WriteLine($"Number of KVP: {letterCount.Count}");

            foreach (var key in letterCount.Keys)
            {
                Console.WriteLine($"A set of unique keys: {key}");
            }

            foreach (var value in letterCount.Values)
            {
                Console.WriteLine($"A collection of all values: {value}");
            }

            SortedDictionary<string, int> myDict = new SortedDictionary<string, int>();

            myDict["Maria"] = 40;
            myDict["DIG"] = 42;
            myDict["Ali"] = 12;


            foreach (var nameAge in myDict)
            {
                Console.WriteLine($"{nameAge.Key} - {nameAge.Value}");
            }
            Console.WriteLine($"{myDict.Count}");

            var keys = myDict.Keys;

            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();

            foreach (var kvp in myDict)
            {
                Console.WriteLine(kvp.Key);
            }

            Console.WriteLine();

            var listOfKeys = new List<string>();

            foreach (var kvp in myDict)
            {
                listOfKeys.Add(kvp.Key);
            }

            Console.WriteLine();

            foreach (var keysList in listOfKeys)
            {
                Console.WriteLine(keysList);
            }
            Console.WriteLine();

            Console.WriteLine(String.Join(", ", listOfKeys));

            Console.WriteLine();

            var values = myDict.Values;

            foreach (var myDictValues in values)
            {
                Console.WriteLine(myDictValues);
            }

            Console.WriteLine();

            foreach (var myDictValues in myDict)
            {
                Console.WriteLine(myDictValues.Value);
            }

            Console.WriteLine();

            myDict.Add("Gosho", 11); //Дабавя само ако няма такъв елемент 
            //dict["Gosho"] = 11; - добавя или презаписва

            myDict.Add("Tedy", 18);

            foreach (var myDictValues in myDict)
            {
                Console.WriteLine($"{myDictValues.Key}, {myDictValues.Value}");
            }

            Console.WriteLine();

            foreach (var KVP in myDict)
            {
                Console.WriteLine(KVP);
            }

            Console.WriteLine();

            var someValue = myDict["Tedy"];

            Console.WriteLine(someValue);

            Console.WriteLine();

            bool hasSomaName = myDict.ContainsKey("Ali");

            Console.WriteLine(hasSomaName);

            Console.WriteLine();

            if (!myDict.ContainsKey("Ali"))
            {
                myDict.Add("Ali", 12);
            }

            if (!myDict.ContainsValue(14))
            {
                Console.WriteLine("YES!");
            }

            Console.WriteLine();

            if (myDict.ContainsKey("Ali"))
            {
                Console.WriteLine(myDict["Ali"]);
            }
            Console.WriteLine();

            int theValue;
            bool hasValue = myDict.TryGetValue("Ali", out theValue);

            if (hasValue)
            {
                Console.WriteLine(theValue);
            }

            Console.WriteLine();

            Console.WriteLine("Problem: Odd Occurrences");
            Console.WriteLine();

            var words = "Java C# PHP PHP JAVA C java".Split(' ');
            //var words = Console.ReadLine().ToLower();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var wordToLower = word.ToLower();

                if (wordCount.ContainsKey(wordToLower))
                {
                    wordCount[wordToLower]++;
                }
                else
                {
                    wordCount[wordToLower] = 1;
                }
            }

            var result = new List<string>();

            foreach (var kvp in wordCount)
            {
                var word = kvp.Key;
                var count = kvp.Value;

                if (count % 2 == 1)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(String.Join(", ", result));

            Console.WriteLine("Count Real Numbers (8 2.5 2.5 8 2.5)");

            var numbers = "8 2.5 2.5 8 2.5".Split(' ').Select(double.Parse).ToArray();

            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount[number] = 1;
                }
                else
                {
                    numbersCount[number]++;
                }
            }

            foreach (var kvp in numbersCount.Reverse())
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine("LINQ");

          //  Console.WriteLine("Input number of numbers:");

         //   var n = int.Parse(Console.ReadLine());
         //
         //   var nums = new List<int>();
         //
         //   for (int i = 0; i < n; i++)
         //   {
         //       nums.Add(int.Parse(Console.ReadLine()));
         //   }
         //
         //   Console.WriteLine($"SUM = {nums.Sum()}");
         //   Console.WriteLine($"MIN = {nums.Min()}");
         //   Console.WriteLine($"MAX = {nums.Max()}");
         //   Console.WriteLine($"Average = {nums.Average()}");
         //
            Console.WriteLine("Select");

           int[] someArr = new int[4];

            someArr[0] = 2;
            someArr[1] = 10;
            someArr[2] = 30;
            someArr[3] = 9;

            var multiplyNum = someArr.Select(n1 => n1 * 100);

            Console.WriteLine(string.Join(", ", multiplyNum));


            var addTen = multiplyNum.Select(Addten);

            var sorted = addTen.OrderBy(n2 => n2);

            Console.WriteLine(string.Join(", ", sorted));

            Console.WriteLine("Sorting by Value");

            var dict = new Dictionary<string, int>();

            dict["Ivan"] = 15;
            dict["Pesho"] = 1;
            dict["Gosho"] = 35;

            var sortedNames = dict.OrderBy(kvp => kvp.Value);

            Console.WriteLine(String.Join(", ", sortedNames));

            foreach (var kvp in sortedNames)
            {
                Console.WriteLine($"{kvp.Value} -> {kvp.Key}");
            }

            var namesToDict = sortedNames.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.WriteLine(String.Join(", ", namesToDict));

            Console.WriteLine("ToDictionary");

            var listOfWords = new List<string>
            {
                "Ivan", "Myri", "Pesho"
            };

            Dictionary<string, int> wordToLength = listOfWords.ToDictionary(word => word, word => word.Length);

            var lengthOfIvan = wordToLength["Ivan"];

            Console.WriteLine(lengthOfIvan);

        Console.WriteLine("Take");

            var numbersInput = new List<int>
            {
                1, 2, 3, 4, 5
            };

           var  numbersSkip = numbersInput.Skip(2).ToList();

            Console.WriteLine(String.Join(", ", numbersSkip));

            var takeNumber = numbersSkip.Take(2);

            Console.WriteLine(String.Join(", ", takeNumber));

            Console.WriteLine("Random");

            var random = new Random();

            var firstRandom = random.Next(0, 101); //0 - 100
            var secondRandom = random.Next(0, 101);

            Console.WriteLine(firstRandom);  
            Console.WriteLine(secondRandom);

            //       Console.WriteLine("Sort numbers in desending order - the last 3 numbers:");
            //
            //       Console
            //           .ReadLine()
            //           .Split(' ')
            //           .Select(double.Parse)
            //           .OrderByDescending(n => n)
            //           .Take(3)
            //           .ToList()
            //           .ForEach(Console.WriteLine);

            Console.WriteLine("Where");

            var list = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            list = list.Where(x => x % 2 == 0 && x <= 6).ToList();

            var countEven = list.Count(x => x % 2 == 0 && x <= 6);

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(countEven);

        //    Console.WriteLine("Input: In SoftUni you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!");
        //
        //    var resultEnd = Console.ReadLine()
        //        .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Where(w => w.Length < 5)
        //        .Select(w => w)
        //        .Distinct()
        //        .ToList();
        //
        //    Console.WriteLine(String.Join(", ", resultEnd));
        //
        //    Console.WriteLine("First, Last");

            var listFirstLast = new List<int> { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
            var second = new List<int> { 1, 2, 4, 5, 6, 7, 8, 9, 10 };

            var first = listFirstLast.First();
            Console.WriteLine(first);

            first = listFirstLast.FirstOrDefault();
            Console.WriteLine(first);

            first = listFirstLast.FirstOrDefault(x => x > 5); //ако няма не гърми
            Console.WriteLine(first);

            var resultFirstSecond = listFirstLast.Concat(second);

            Console.WriteLine(string.Join(", ", resultFirstSecond));

        }

            static int Addten(int add)
            {
                return add + 10;
            }

    }
}
