using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length-1, 1);
                noun = noun.Insert(noun.Length, "ies");
                Console.WriteLine(noun);
            }

            else if (noun.EndsWith("o") || noun.EndsWith("s") || noun.EndsWith("x") || noun.EndsWith("z") || noun.EndsWith("ch") || noun.EndsWith("sh"))
            {
                noun = noun.Insert(noun.Length, "es");
                Console.WriteLine(noun);
            }

            else
            {
                noun = noun.Insert(noun.Length, "s");
                Console.WriteLine(noun);
            }

            Console.ReadLine();

        }
    }
}
