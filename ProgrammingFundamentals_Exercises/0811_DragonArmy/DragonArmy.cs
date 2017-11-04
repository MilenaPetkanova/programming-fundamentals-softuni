using System;
using System.Collections.Generic;
using System.Linq;

class DragonArmy
{
    static void Main()
    {
        var allDragons = new Dictionary<string, 
            SortedDictionary<string, double[]>>();

        int dragoncounter = int.Parse(Console.ReadLine());
        for (int i = 0; i < dragoncounter; i++)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            string type = tokens[0];
            string dragon = tokens[1];
            double damage = 0;
            double health = 0;
            double armor = 0;

            damage = tokens[2] != "null" ? double.Parse(tokens[2]) : 45;
            health = tokens[3] != "null" ? double.Parse(tokens[3]) : 250;
            armor = tokens[4] != "null" ? double.Parse(tokens[4]) : 10;

            double[] stats = new double[] { damage, health, armor };

            if (!allDragons.ContainsKey(type))
            {
                allDragons.Add(type, new SortedDictionary<string, double[]>());
            }
            if (!allDragons[type].ContainsKey(dragon))
            {
                allDragons[type].Add(dragon, stats);
            }

            allDragons[type][dragon] = stats;
        }

        foreach (var type in allDragons)
        {
            double totalDamage = type.Value.Values.Average(x => x[0]);
            double totalHealth = type.Value.Values.Average(x => x[1]);
            double totalArmor = type.Value.Values.Average(x => x[2]);

            Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", 
                type.Key, totalDamage, totalHealth, totalArmor);

            foreach (var dragon in allDragons[type.Key])
            {
                Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",
                    dragon.Key, dragon.Value[0], dragon.Value[1], dragon.Value[2]);
            }
        }


    }
}
