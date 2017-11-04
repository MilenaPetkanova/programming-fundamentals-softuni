using System;
using System.Numerics;

namespace _10_CenturiesInNanoseconds
{
    class CenturiesInNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)Math.Floor(years * 365.2422);
            uint hours = (uint)days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds;
            nanoseconds *= 1000;

            Console.WriteLine($"{centuries} centuries = " +
                $"{years} years = " +
                $"{days} days = " +
                $"{hours} hours = " +
                $"{minutes} minutes = " +
                $"{seconds} seconds = " +
                $"{milliseconds} milliseconds = " +
                $"{microseconds} microseconds = " +
                $"{nanoseconds} nanoseconds");
        }
    }
}
