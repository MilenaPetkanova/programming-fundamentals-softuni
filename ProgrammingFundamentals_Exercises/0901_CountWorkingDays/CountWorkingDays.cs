using System;
using System.Globalization;
using System.Linq;

class CountWorkingDays
{
    static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        DateTime startDate = DateTime
            .ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime
            .ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        int workingDaysCounter = 0;

        for (var i = 0; i <= (endDate - startDate).TotalDays; i++)
        {
            DateTime date = new DateTime();
            date = startDate.AddDays(i);

            DateTime[] holidays = new DateTime[]
            {
                new DateTime(date.Year, 1, 1),
                new DateTime(date.Year, 3, 3),
                new DateTime(date.Year, 5, 1),
                new DateTime(date.Year, 5, 6),
                new DateTime(date.Year, 5, 24),
                new DateTime(date.Year, 9, 6),
                new DateTime(date.Year, 9, 22),
                new DateTime(date.Year, 11, 1),
                new DateTime(date.Year, 12, 24),
                new DateTime(date.Year, 12, 25),
                new DateTime(date.Year, 12, 26)
            };
            //Same result, better date formatting:
            //DateTime[] holidays = new DateTime[]
            //{           
            //    DateTime
            //        .ParseExact("01*01*1970", "dd-MM-yyyy", 
            //        CultureInfo.InvariantCulture)
            //    //Same for all official holidays
            //};

            if (!isHoliday(date, holidays))
            {
                workingDaysCounter++;
            }
        }

        Console.WriteLine(workingDaysCounter);

    }

    public static bool isHoliday(DateTime currentDate, DateTime[] holidays)
    {
        return holidays.Any(h => h.Day == currentDate.Day && h.Month == currentDate.Month)
               || (currentDate.DayOfWeek == DayOfWeek.Saturday)
               || (currentDate.DayOfWeek == DayOfWeek.Sunday);
    }
}
