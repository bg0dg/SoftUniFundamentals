using System;

namespace _01._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal meneyPerKM = decimal.Parse(Console.ReadLine());

            if (runners > trackCapacity * days)
            {
                runners = trackCapacity * days;
            }

            long totalMetars = runners * laps * trackLength;
            long totalKM = totalMetars / 1000;

            decimal raisedMoney = totalKM * meneyPerKM;

            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}



