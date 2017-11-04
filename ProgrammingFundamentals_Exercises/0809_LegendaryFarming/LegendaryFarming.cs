using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming
{
    static void Main()
    {
        var keyMaterials = new SortedDictionary<string, double>();
        keyMaterials.Add("shards", 0);
        keyMaterials.Add("fragments", 0);
        keyMaterials.Add("motes", 0);

        var junkMaterials = new SortedDictionary<string, double>();

        bool isObtained = false;
        do
        {
            List<string> input = Console.ReadLine().Split(' ')
                .Select(x => x.ToLower()).ToList();

            for (int i = 1; i < input.Count; i += 2)
            {
                if (input[i] == "shards")
                {
                    keyMaterials["shards"] += double.Parse(input[i - 1]);
                    if (keyMaterials["shards"] >= 250)
                    {
                        isObtained = true;
                        string obtained = "Shadowmourne";
                        keyMaterials["shards"] -= 250;
                        PrintLegendary(obtained, keyMaterials, junkMaterials);
                        break;
                    }
                }
                else if (input[i] == "fragments")
                {
                    keyMaterials["fragments"] += double.Parse(input[i - 1]);
                    if (keyMaterials["fragments"] >= 250)
                    {
                        isObtained = true;
                        string obtained = "Valanyr";
                        keyMaterials["fragments"] -= 250;
                        PrintLegendary(obtained, keyMaterials, junkMaterials);
                        break;
                    }
                }
                else if (input[i] == "motes")
                {
                    keyMaterials["motes"] += double.Parse(input[i - 1]);
                    if (keyMaterials["motes"] >= 250)
                    {
                        isObtained = true;
                        string obtained = "Dragonwrath";
                        keyMaterials["motes"] -= 250;
                        PrintLegendary(obtained, keyMaterials, junkMaterials);
                        break;
                    }
                }
                else
                {
                    if (!junkMaterials.ContainsKey(input[i]))
                    {
                        junkMaterials.Add(input[i], double.Parse(input[i - 1]));
                    }
                    else
                    {
                        junkMaterials[input[i]] += double.Parse(input[i - 1]);
                    }
                }
            }
        }
        while (isObtained == false);
    }

    private static void PrintLegendary(string obtained, SortedDictionary<string, double> keyMaterials, SortedDictionary<string, double> junkMaterials)
    {
        Console.WriteLine($"{obtained} obtained!");
        foreach (var material in keyMaterials.OrderByDescending(v => v.Value))
        {
            Console.WriteLine("{0}: {1}", material.Key, material.Value);
        }
        foreach (var material in junkMaterials)
        {
            Console.WriteLine("{0}: {1}", material.Key, material.Value);
        }
    }
}
