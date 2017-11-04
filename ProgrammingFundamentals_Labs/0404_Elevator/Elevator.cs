using System;

class Elevator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int courses = n / p;

        if (n % p > 0)
        {
            courses++;
        }
        Console.WriteLine(courses);

        // Other solution:
        // int courses = (int)Math.Ceiling((double)n / p);
    }
}
