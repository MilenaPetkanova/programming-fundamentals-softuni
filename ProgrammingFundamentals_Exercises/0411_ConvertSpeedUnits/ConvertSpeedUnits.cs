using System;

namespace _0411_ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            double distanceInMeters = double.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            long distanceInSeconds = seconds + minutes * 60 + hours * 3600;
            double metersPerSecond = distanceInMeters / distanceInSeconds;

            double distanceInKm = distanceInMeters / 1000.00;
            double hoursReal = (double)distanceInSeconds / 3600;
            double kilometersPerHour = distanceInKm / hoursReal;

            double distanceInMiles = distanceInMeters / 1609;
            double milesPerHour = distanceInMiles / hoursReal;

            Console.WriteLine("{0}", (float)metersPerSecond);
            Console.WriteLine("{0}", (float)kilometersPerHour);
            Console.WriteLine("{0}", (float)milesPerHour);
        }
    }
}
