using System;
using System.Collections.Generic;
using System.Linq;

namespace _0705_SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {

            List<double> numbers = Console.ReadLine()
                .Split(' ').Select(double.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(String.Join(" <= ", numbers));
        }
    }
}
