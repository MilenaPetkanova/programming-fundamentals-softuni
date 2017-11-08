using System;
using System.Collections.Generic;
using System.Linq;

internal class DataSet
{
    public string Name { get; set; }
    public Dictionary<string, int> KeysSizes { get; set; }
    public long SumSizes { get; set; }
}

class AnonimousCache
{
    static void Main()
    {
        var existingSets = new List<DataSet>();
        var cashe = new List<DataSet>();

        var input = Console.ReadLine();
        while (input != "thetinggoesskrra")
        {
            var tokens = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (tokens.Length == 1)
            {
                string name = tokens[0];

                if (!existingSets.Any(x => x.Name == name))
                {
                    var dataSet = new DataSet();
                    dataSet.Name = name;
                    dataSet.KeysSizes = new Dictionary<string, int>();
                    dataSet.SumSizes = 0;

                    existingSets.Add(dataSet);
                }
                if (cashe.Any(x => x.Name == name))
                {
                    var exist = cashe.Find(x => x.Name == name);

                    existingSets.Add(exist);
                }
            }

            else
            {
                string name = tokens[2];
                string key = tokens[0];
                int size = int.Parse(tokens[1]);

                if (existingSets.Any(x => x.Name == name))
                {
                    var exist = existingSets.Find(x => x.Name == name);
                    exist.KeysSizes.Add(key, size);
                    exist.SumSizes += size;
                }
                else
                {
                    if (!cashe.Any(x => x.Name == name))
                    {
                        var dataSet = new DataSet();
                        dataSet.Name = name;
                        dataSet.KeysSizes = new Dictionary<string, int>();
                        dataSet.KeysSizes.Add(key, size);
                        dataSet.SumSizes += size;

                        cashe.Add(dataSet);
                    }
                    else
                    {
                        var exist = cashe.Find(x => x.Name == name);
                        exist.KeysSizes.Add(key, size);
                        exist.SumSizes += size;
                    }

                }
            }

            input = Console.ReadLine();
        }

        if (existingSets.Count == 0)
        {
            return;
        }

        foreach (var set in existingSets.OrderByDescending(x => x.SumSizes))
        {
            Console.WriteLine($"Data Set: {set.Name}, " +
                $"Total Size: {set.SumSizes}");

            foreach (var keySet in set.KeysSizes)
            {
                Console.WriteLine($"$.{keySet.Key}");
            }
            return;
        }

    }
}
