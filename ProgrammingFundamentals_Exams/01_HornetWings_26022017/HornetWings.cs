using System;

class HornetWings
{
    static void Main()
    {
        int wingFlaps = int.Parse(Console.ReadLine());
        double distancePer1000 = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());

        double metersTraveled = (wingFlaps / 1000) * distancePer1000;
        long secondsPassed = wingFlaps / 100;
        secondsPassed += (wingFlaps / endurance) * 5;

        Console.WriteLine("{0:F2} m.", metersTraveled);
        Console.WriteLine($"{secondsPassed} s.");
    }
}
