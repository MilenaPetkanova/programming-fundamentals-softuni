using System;

class BeverageLabels
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyPer100 = double.Parse(Console.ReadLine());
        double sugarPer100 = double.Parse(Console.ReadLine());

        double energyContent = volume * energyPer100 / 100;
        double sugarContent = volume * sugarPer100 / 100;

        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
    }
}
