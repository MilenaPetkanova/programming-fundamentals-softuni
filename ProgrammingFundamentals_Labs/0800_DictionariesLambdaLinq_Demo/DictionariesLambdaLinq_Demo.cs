using System;
using System.Collections.Generic;
using System.Linq;

class DictionariesLambdaLinq_Demo
{
    static void Main()
    {
        //08.Programming - Fundamentals - Dictionaries - Lambda - LINQ - Lab

        //
        var phonebook = new Dictionary<string, string>();
        phonebook["John Smith"] = "+1-555-8976";
        phonebook["Lisa Smith"] = "+1-555-1234";
        phonebook["Sam Doe"] = "+1-555-5030";
        phonebook["Nakov"] = "+359-899-555-592";
        phonebook["Nakov"] = "+359-2-981-9819"; // Replace
        phonebook.Remove("John Smith");
        foreach (var pair in phonebook)
            Console.WriteLine("{0} --> {1}",
              pair.Key, pair.Value);

        //
        var events = new SortedDictionary<DateTime, string>();
        events[new DateTime(1998, 9, 4)] = "Google's birth date";
        events[new DateTime(2013, 11, 5)] = "SoftUni's birth date";
        events[new DateTime(1975, 4, 4)] = "Microsoft's birth date";
        events[new DateTime(2004, 2, 4)] = "Facebook's birth date";
        events[new DateTime(2013, 11, 5)] = "SoftUni was founded";
        foreach (var entry in events)
        {
            Console.WriteLine("{0:dd-MMM-yyyy}: {1}",
               entry.Key, entry.Value);
        }

        //
        var items = Console.ReadLine().Split(' ')
            .Select(number => int.Parse(number))
            .ToArray();
        var items2 = Console.ReadLine().Split(' ') // same parsing
            .Select(int.Parse).ToList();

        //
        List<int> nums = new List<int> { 1, 5, 2, 4, 3 };
        nums = nums.OrderBy(num => num).ToList();
        Console.WriteLine(String.Join(", ", nums));

        nums = nums.OrderByDescending(num => num).ToList();
        Console.WriteLine(String.Join(", ", nums));

        //
        var products = new Dictionary<int, string>();

        Dictionary<int, string> sortedDict = products
          .OrderBy(pair => pair.Value)
          .ThenBy(pair => pair.Key)
          .ToDictionary(pair => pair.Key, pair => pair.Value);

        Console.WriteLine(String.Join(", ", sortedDict.Values));

        //
        var nums1 = new List<int>() { 10, 20, 30, 40, 50, 60 }
                .Take(3).ToArray();
        var nums2 = new List<int>() { 10, 20, 30, 40, 50, 60 }
                .Skip(3)
                .Take(2).ToArray();

        //
        int[] nums3 = { 1, 2, 3, 4, 5, 6 };
        nums3 = nums3
            .Where(num => num % 2 == 0)
            .ToArray();       // nums = [2, 4, 6]

        int[] nums4 = { 1, 2, 3, 4, 5, 6 };
        int count = nums4
            .Count(num => num % 2 == 0);   // count = 3

        //
        int[] nums99 = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };
        nums99.OrderBy(x => x).Take(3);  // 11 22 33
        nums99.Where(x => x < 50);   // 11 33 44 22
        nums99.Count(x => x % 2 == 1);   // 55
        nums99.Select(x => x * 2).Take(5);   // 22 198 66 110 154

        //
        int[] nums9 = { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };
        nums9 = nums9.Distinct().ToArray();   // nums = [1, 2, 3, 4, 5, 6, -2, 0, 15]

        //
        int[] nums8 = { 1, 2, 3, 4, 5, 6 };
        int firstNum = nums8.First(x => x % 2 == 0); // 2
        int lastNum = nums8.Last(x => x % 2 == 1); // 5
        int singleNum = nums8.Single(x => x == 4); // 4

        //
        int[] nums11 = { 1, 2, 3, 4, 5, 6 };
        nums11 = nums11.Reverse().ToArray();   // nums = 6, 5, 4, 3, 2, 1

        int[] nums12 = { 1, 2, 3, 4, 5, 6 };
        int[] otherNums = { 7, 8, 9, 0 };
        nums12 = nums12.Concat(otherNums).ToArray(); // nums = 1, 2, 3, 4, 5, 6, 7, 8, 9, 0


        ////Nested dictionaries:
        Dictionary<string, Dictionary<string, int>> dictinary = 
            new Dictionary<string, Dictionary<string, int>>();

        //dictinary.Add(key, new Dictionary<string, int>());
        //dictinary[firstKey].Add(secondKey, value);

        //dictinary[firstKey][secondkey] = value;

        //dictinary.ContainsKey(firstKey);
        //dictinary[firstKey].ContainsKey(secondKey);

        //dictinary.OrderBy(x => x.Key);
        //dictinary[firstKey].OrderBy(x => x.Key);
    }
}
