using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215_NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int roundCounter = 0;
            string attacker = "";
            string attack = "";
            string winner = "";

            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1) //pesho's turn
                {
                    roundCounter++;
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    if (peshoHealth <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else if (i % 2 == 0) //gosho's turn
                {
                    roundCounter++;
                    peshoHealth -= goshoDamage;
                    if (goshoHealth <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    if (peshoHealth <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                if (roundCounter % 3 == 0)  //health bonuses
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
            Console.WriteLine($"{winner} won in {roundCounter}th round.");
        }
    }
}
