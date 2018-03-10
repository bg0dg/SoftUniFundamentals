using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Nether_Realms_second
{
    class DemonsScore
    {
        public int demonHealths { get; set; }
        public double demonDamages { get; set; }

        public DemonsScore(int demonHealthsC, double demonDamagesC)
        {
            demonHealths = demonHealthsC;
            demonDamages = demonDamagesC;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var demonsResult = new SortedDictionary<string, DemonsScore>();

            var pattern = @"-?\d+\.?\d*";
            var regex = new Regex(pattern);

            foreach (var demon in demons)
            {
                var health = demon
                        .Where(s => !char.IsDigit(s)
                            && s != '+' && s != '-' && s != '*'
                            && s != '/' && s != '.')
                        .Sum(s => s);

                var matches = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                    var value = match.Value;
                    damage += double.Parse(value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                DemonsScore score = new DemonsScore(health, damage);

                demonsResult[demon] = score;
            }

            foreach (var demon in demonsResult)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.demonHealths} health, {demon.Value.demonDamages:f2} damage");
            }
 
        }
    }
}
