using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Nether_Realms_third
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

            foreach (var demon in demons)
            {
                var health = DemonHealth(demon);

                var damage = Demondamage(demon);

                DemonsScore score = new DemonsScore(health, damage);

                demonsResult[demon] = score;
            }

            foreach (var demon in demonsResult)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.demonHealths} health, {demon.Value.demonDamages:f2} damage");
            }

        }
        static int DemonHealth(string demon)
        {
            var health = demon
            .Where(s => !char.IsDigit(s)
                && s != '+' && s != '-' && s != '*'
                && s != '/' && s != '.')
            .Sum(s => s);
            return health;
        }

        static double Demondamage(string demon)
        {
            var pattern = @"-?\d+\.?\d*";
            var regex = new Regex(pattern);
            var damage = 0.0;
            var matches = regex.Matches(demon);

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
            return damage;
        }
    }

}
