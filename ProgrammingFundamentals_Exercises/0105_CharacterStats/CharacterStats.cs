using System;

class CharacterStats
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var currHealth = int.Parse(Console.ReadLine());
        var maxHealth = int.Parse(Console.ReadLine());
        var currEnergy = int.Parse(Console.ReadLine());
        var maxEnergy = int.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Health: {0}{1}{2}{0}", 
            '|', new string('|', currHealth), new string('.', maxHealth - currHealth));
        Console.WriteLine("Energy: {0}{1}{2}{0}", 
            '|', new string('|', currEnergy), new string('.', maxEnergy - currEnergy));
    }
}
