﻿using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);

        var holidaysCount = 0;

        if (startDate <= endDate)
        {
            for (var date = startDate; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
                date = date.AddDays(1);
            }
        }

        else
        {
            holidaysCount = 0;
        }

        Console.WriteLine(holidaysCount);
    }
}
