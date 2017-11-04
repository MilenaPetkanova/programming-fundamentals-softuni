using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCenter
{
    static void Main()
    {
        var report = new Dictionary<string, Dictionary<string, long>>();

        string input = Console.ReadLine();
        while (input != "report")
        {
            var inputArgs = input.Split('|').ToArray();
            string city = inputArgs[0];
            string country = inputArgs[1];
            int population = int.Parse(inputArgs[2]);

            if (!report.ContainsKey(country))
            {
                report.Add(country, new Dictionary<string, long>());
            }
            if (!report[country].ContainsKey(city))
            {
                report[country].Add(city, 0);
            }
            report[country][city] += population;

            input = Console.ReadLine();
        }

        var sortedCounties = report
            .OrderByDescending(x => x.Value.Sum(y => y.Value));

        foreach (var country in sortedCounties)
        {
            List<long> sum = country
                .Value.Select(x => x.Value).ToList();
            Console.WriteLine("{0} (total population: {1})", 
                country.Key, sum.Sum());

            var sortedCities = report[country.Key]
                .OrderByDescending(x => x.Value);

            foreach (var city in sortedCities)
            {
                Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
            }
        }
    }
}
