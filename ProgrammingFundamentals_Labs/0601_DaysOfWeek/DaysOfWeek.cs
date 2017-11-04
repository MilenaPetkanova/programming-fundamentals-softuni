using System;

namespace _0601_DaysOfWeek
{
    class DaysOfWeek
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (input >= 1 && input <= 7)
            {
                Console.WriteLine(daysOfWeek[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
