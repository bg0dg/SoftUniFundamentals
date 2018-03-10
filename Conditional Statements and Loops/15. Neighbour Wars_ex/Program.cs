using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var damageOfPesho = int.Parse(Console.ReadLine());
            var damageOfGosho = int.Parse(Console.ReadLine());
            var pointsOfPesho = 100;
            var pointsOfGosho = 100;
            int counterAddPoints = 0;
            int counterRounds = 0;

            while (true)
            { 
                counterAddPoints++;
                counterRounds++;

                pointsOfGosho -= damageOfPesho;

                if (pointsOfGosho > 0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {pointsOfGosho} health.");
                }

                else if (pointsOfGosho <= 0)
                {
                    Console.WriteLine($"Pesho won in {counterRounds}th round.");
                    return;
                }

                if (counterAddPoints == 3)
                {
                    counterAddPoints = 0;
                    pointsOfPesho += 10;
                    pointsOfGosho += 10;
                }

                counterAddPoints++;
                counterRounds++;

                pointsOfPesho -= damageOfGosho;

                if (pointsOfPesho > 0)
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pointsOfPesho} health.");
                }

                else if (pointsOfPesho <= 0)
                {
                    Console.WriteLine($"Gosho won in {counterRounds}th round.");
                    return;
                }

                if (counterAddPoints == 3)
                {
                    counterAddPoints = 0;
                    pointsOfPesho += 10;
                    pointsOfGosho += 10;
                }
            }
        }
    }
}
