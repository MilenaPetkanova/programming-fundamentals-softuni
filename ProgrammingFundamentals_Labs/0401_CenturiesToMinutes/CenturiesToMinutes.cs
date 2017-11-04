using System;

class CenturiesToMinutes
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());

        int years = centuries * 100;
        int days = (int)Math.Floor(years * 365.2425);
        int hours = days * 24;
        int minutes = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} " +
            $"days = {hours} hours = {minutes} minutes");
    }
}
