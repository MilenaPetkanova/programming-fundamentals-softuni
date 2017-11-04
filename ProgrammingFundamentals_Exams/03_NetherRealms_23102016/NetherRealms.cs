using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Dragon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
}

class NetherRealms
{
    static void Main()
    {
        var allDragons = new SortedList<string, Dragon>();

        string input = Console.ReadLine();

        string[] dragons = input.Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        foreach (var dragon in dragons)
        {
            var newDragon = new Dragon()
            {
                Name = dragon,
                Health = CalculateHealth(dragon),
                Damage = CalculateDamage(dragon)
            };

            allDragons.Add(dragon, newDragon);
        }

        PrintDragons(allDragons);
    }

    private static void PrintDragons(SortedList<string, Dragon> allDragons)
    {
        foreach (var dragon in allDragons)
        {
            Console.WriteLine("{0} - {1} health, {2:f2} damage",
               dragon.Key, dragon.Value.Health, dragon.Value.Damage);
        }
    }

    private static double CalculateDamage(string dragon)
    {
        double damage = 0.00;

        string damagePattern = @"(-?\d+(?:\.?\d+)?)";
        var matches = Regex.Matches(dragon, damagePattern);

        foreach (Match m in matches)
        {
            double d = double.Parse(m.ToString());
            damage += d;
        }

        var multiplyOrDivive = Regex.Matches(dragon, @"(\/|\*)");
        foreach (Match m in multiplyOrDivive)
        {
            string sign = m.ToString();
            if (sign == "*")
            {
                damage *= 2;
            }
            else if (sign == "/")
            {
                damage /= 2;
            }
        }

        return damage;
    }

    private static int CalculateHealth(string dragon)
    {
        int health = 0;

        string healthPattern = @"([^\d\-+*\/.])";
        var matches = Regex.Matches(dragon, healthPattern);

        foreach (Match m in matches)
        {
            string match = m.ToString();
            foreach (char ch in match)
            {
                health += ch;
            }
        }

        return health;
    }
}
