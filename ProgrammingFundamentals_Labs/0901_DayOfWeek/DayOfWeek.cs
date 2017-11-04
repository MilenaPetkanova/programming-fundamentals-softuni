using System;
using System.Globalization;
using System.Linq;

class DayOfWeek
{
    static void Main()
    {
        //First solution:
        string input = Console.ReadLine();

        DateTime date = DateTime.ParseExact(input, "d-M-yyyy",
            CultureInfo.InvariantCulture);

        Console.WriteLine(date.DayOfWeek);


        //Second solution:
        //var input = Console.ReadLine().Split('-')
        //    .Select(int.Parse).ToArray();

        //int day = input[0];
        //int month = input[1];
        //int year = input[2];

        //DateTime date = new DateTime(year, month, day);
        //string dayOfWeek = date.DayOfWeek.ToString();
        //Console.WriteLine(dayOfWeek);
    }
}
 