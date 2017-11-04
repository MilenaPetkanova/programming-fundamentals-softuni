using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Country
{
    public string Name { get; set; }
    public Dictionary<string, long> Cities { get; set; }
    public int CitiesCounter { get; set; }
}

class PopulationAggregation
{
    static void Main()
    {
        var allCountries = new SortedDictionary<string, Country>();
        var allCities = new Dictionary<string, long>();

        string input = Console.ReadLine();
        while (input != "stop")
        {
            string[] inputArgs = input.Split('\\').ToArray();
            long population = long.Parse(inputArgs[2]);
            string newCountry;
            string city;

            if (char.IsUpper(inputArgs[0].First()))
            {
                newCountry = inputArgs[0];
                newCountry = RemoveSpecialCharacters(newCountry);
                city = inputArgs[1];
                city = RemoveSpecialCharacters(city);
            }
            else 
            {
                newCountry = inputArgs[1];
                newCountry = RemoveSpecialCharacters(newCountry);
                city = inputArgs[0];
                city = RemoveSpecialCharacters(city);
            }

            Country country = new Country
            {
                Name = newCountry,
                Cities = new Dictionary<string, long>(),
                CitiesCounter = 1
            };

            if (!allCountries.ContainsKey(newCountry))
            {
                allCountries.Add(newCountry, country);
                allCountries[newCountry].Cities.Add(city, population);
                allCities.Add(city, population);
            }
            else
            {
                if (!allCountries[newCountry].Cities.ContainsKey(city))
                {
                    allCountries[newCountry].Cities.Add(city, population);
                    allCities.Add(city, population);
                }
                else
                {
                    allCountries[newCountry].Cities[city] = population;
                    allCities[city] = population;
                }
                allCountries[newCountry].CitiesCounter += 1;
            }

            input = Console.ReadLine();
        }

        foreach (var country in allCountries)
        {
            Console.WriteLine($"{country.Key} -> {country.Value.CitiesCounter}");
        }

        int citiesStopper = 1;
        foreach (var city in allCities.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{city.Key} -> {city.Value}");
            if (citiesStopper == 3)
            {
                break;
            }

            citiesStopper++;
        }
    }

    public static string RemoveSpecialCharacters(string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in str)
        {
            if (char.IsDigit(c))
            {
                continue;
            }
            if ((c != '@') && (c != '$') && (c != '#') && (c != '&'))
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}

