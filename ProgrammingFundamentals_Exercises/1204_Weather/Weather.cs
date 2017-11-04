using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Weather
{
    static void Main()
    {
        var citiesTemperatures = new Dictionary<string, double>();
        var citiesTypes = new SortedList<string, string>();

        string input = Console.ReadLine();
        while (input != "end")
        {
            string pattern = @"([A-Z]{2})(\d+.\d{1,2})([a-zA-Z]+)\|";
            if (Regex.IsMatch(input, pattern))
            {
                var match = Regex.Match(input, pattern);
                string city = match.Groups[1].ToString();
                double average = double.Parse(match.Groups[2].ToString());
                string type = match.Groups[3].ToString();

                citiesTemperatures[city] = average;
                citiesTypes[city] = type;
            }

            input = Console.ReadLine();
        }

        var sortedCities = citiesTemperatures
            .OrderBy(x => x.Value)
            .ToDictionary(x => x.Key, y => y.Value);

        foreach (var city in sortedCities)
        {
            Console.WriteLine("{0} => {1:f2} => {2}",
            city.Key, city.Value, citiesTypes[city.Key]);
        }
    }
}
