using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ')
                    .Select(double.Parse).ToArray();
        var count = new SortedDictionary<double, int>();

        foreach (var num in nums)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        foreach (var item in count)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
        //Same:
        //foreach (var num in count.Keys)
        //{
        //    Console.WriteLine($"{num} -> {count[num]}");
        //}
    }
}
