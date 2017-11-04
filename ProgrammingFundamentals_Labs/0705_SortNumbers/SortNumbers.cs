using System;
using System.Collections.Generic;
using System.Linq;

class SortNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine()
            .Split(' ').Select(double.Parse).ToList();

        numbers.Sort();

        Console.WriteLine(String.Join(" <= ", numbers));
    }
}
