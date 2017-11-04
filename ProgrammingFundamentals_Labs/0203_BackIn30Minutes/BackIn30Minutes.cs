using System;

class BackIn30Minutes
{
    static void Main()
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        minutes += 30;

        if (minutes > 59)
        {
            minutes -= 60;
            hours++;
        }

        if (hours > 23)
        {
            hours = 0;
        }

        Console.WriteLine("{0}:{1:D2}", hours, minutes);
    }
}
