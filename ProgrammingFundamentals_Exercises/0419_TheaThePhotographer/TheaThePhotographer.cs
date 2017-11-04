using System;

namespace _0419_TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int allPics = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            byte filterFactor = byte.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            ulong totalTime = (ulong)allPics * (ulong)filterTime; // filter all pics
            double goodPics = Math.Ceiling((double)filterFactor / 100 * allPics);
            totalTime += (ulong)goodPics * (ulong)uploadTime;

            TimeSpan t = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", t);
        }
    }
}
