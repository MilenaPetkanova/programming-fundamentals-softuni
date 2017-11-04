using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;

class ObjectsAndClasses_Demo
{
    static void Main()
    {
        // 09. Programming-Fundamentals-Objects-and-Classes

        //
        DateTime peterBirthday = new DateTime(1996, 11, 27);
        DateTime mariaBirthday = new DateTime(1995, 6, 14);
        Console.WriteLine("Peter's birth date: {0:d-MMM-yyyy}",
          peterBirthday); // 27-Nov-1996
        Console.WriteLine("Maria's birth date: {0:d-MMM-yyyy}",
          mariaBirthday); // 14-Jun-1995
        var mariaAfter18Months = mariaBirthday.AddMonths(18);
        Console.WriteLine("Maria after 18 months: {0:d-MMM-yyyy}",
          mariaAfter18Months); // 14-Dec-1996
        TimeSpan ageDiff = peterBirthday.Subtract(mariaBirthday);
        Console.WriteLine("Maria older than Peter by: {0} days",
          ageDiff.Days); // 532 days

        //
        string dateAsText = Console.ReadLine();
        DateTime date = DateTime.ParseExact(
          dateAsText, "d-M-yyyy",
          CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);

        //Using static .NET class members:
        DateTime today = DateTime.Now;
        double cosine = Math.Cos(Math.PI);

        //Using non-static .NET classes
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 99);

        //Built-in .NET Classes – Examples
        DateTime today2 = DateTime.Now;
        Console.WriteLine("Today is: " + today);
        DateTime tomorrow = today.AddDays(1);
        Console.WriteLine("Tomorrow is: " + tomorrow);
        double angleDegrees = 60;
        double angleRadians = angleDegrees * Math.PI / 180;
        Console.WriteLine(Math.Cos(angleRadians)); // 0.5
        Random rnd2 = new Random();
        Console.WriteLine("Random number = " + rnd.Next(1, 100));
        WebClient webClient = new WebClient();
        webClient.DownloadFile("http://www.introprogramming.info/wp-content/uploads/2015/10/Intro-CSharp-Book-v2015.pdf", "book.pdf");
        Process.Start("book.pdf");

        //Randomize Words
        string[] words = Console.ReadLine().Split(' ');
        Random rnd3 = new Random();
        for (int pos1 = 0; pos1 < words.Length; pos1++)
        {
            int pos2 = rnd.Next(words.Length);
            // TODO: swap words[pos1] with words[pos2]
        }
        Console.WriteLine(string.Join
                        ("Environment.NewLine", words));

        //
    }
}
