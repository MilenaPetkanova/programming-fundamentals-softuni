using System;

class TheaThePhotographer
{
    static void Main(string[] args)
    {
        int totalPics = int.Parse(Console.ReadLine());
        int filterTime = int.Parse(Console.ReadLine());
        int filterFactor = int.Parse(Console.ReadLine());
        int uploadTime = int.Parse(Console.ReadLine());

        double goodPics = Math.Ceiling((double)filterFactor / 100 * totalPics);

        ulong totalSeconds =  (ulong)totalPics * (ulong)filterTime;
        totalSeconds += (ulong)goodPics * (ulong)uploadTime;

        TimeSpan result = TimeSpan.FromSeconds(totalSeconds);
        Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", result);

    }
}
